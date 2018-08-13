namespace Maze
{
    using System;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Text;
    using System.Threading;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;

    using Maze.Common;
    using Maze.Common.Data;

    using Path = System.Windows.Shapes.Path;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        #region Fields

        /// <summary>
        /// The name of the room image data file.
        /// </summary>
        private const string DatFile = "rooms.dat";

        /// <summary>
        /// The current path.
        /// </summary>
        private ObservableCollection<MazeRoom> currentPath;

        /// <summary>
        /// The current room.
        /// </summary>
        private MazeRoom currentRoom;

        /// <summary>
        /// The message text.
        /// </summary>
        private string messageText;

        /// <summary>
        /// Whether the path is complete.
        /// </summary>
        private bool pathComplete;

        /// <summary>
        /// The rooms.
        /// </summary>
        private ObservableCollection<MazeRoom> rooms;

        /// <summary>
        /// Stores room images as byte arrays.
        /// </summary>
        private RoomImages roomImages;

        /// <summary>
        /// Whether to show message text.
        /// </summary>
        private bool showMessageText;

        /// <summary>
        /// Whether to show room text.
        /// </summary>
        private bool showRoomText;

        #endregion // Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();

            // Initialize properties
            this.CurrentPath = new ObservableCollection<MazeRoom>();
            this.Rooms = new ObservableCollection<MazeRoom>();

            // Construct rooms
            this.ConstructRooms();

            // Start the maze!
            this.StartMaze();
        }

        #endregion // Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the current path through the maze.
        /// </summary>
        public ObservableCollection<MazeRoom> CurrentPath
        {
            get => this.currentPath;
            set
            {
                if (value != this.currentPath)
                {
                    this.currentPath = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the current room.
        /// Setter adds room to the current path and builds door links.
        /// </summary>
        public MazeRoom CurrentRoom
        {
            get => this.currentRoom;
            set
            {
                if (value != this.currentRoom)
                {
                    this.currentRoom = value;
                    this.RaisePropertyChanged();

                    // Handle game state
                    this.OnRoomEntered();
                }
            }
        }

        /// <summary>
        /// Gets or sets the list of rooms.
        /// </summary>
        public ObservableCollection<MazeRoom> Rooms
        {
            get => this.rooms;
            set
            {
                if (value != this.rooms)
                {
                    this.rooms = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        #region Display

        /// <summary>
        /// Gets or sets the message text.
        /// </summary>
        public string MessageText
        {
            get => this.messageText;
            set
            {
                if (value != this.messageText)
                {
                    this.messageText = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether to show message text.
        /// </summary>
        public bool ShowMessageText
        {
            get => this.showMessageText;
            set
            {
                if (value != this.showMessageText)
                {
                    this.showMessageText = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether to show room text.
        /// </summary>
        public bool ShowRoomText
        {
            get => this.showRoomText;
            set
            {
                if (value != this.showRoomText)
                {
                    this.showRoomText = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        #endregion // Display

        #endregion // Properties

        #region Methods

        #region Serializing

        /// <summary>
        /// Deserializes an object from a file.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns>The <see cref="object"/>.</returns>
        private static object DeserializeObject(string filePath)
        {
            try
            {
                object returnObject;
                using (var reader = new BinaryReader(File.Open(filePath, FileMode.Open), Encoding.Default))
                {
                    var source = reader.ReadString();
                    var sourceArray = Encoding.Default.GetBytes(source);
                    var sourceStream = new MemoryStream(sourceArray);
                    var sourceFormatter = new BinaryFormatter();
                    returnObject = sourceFormatter.Deserialize(sourceStream);
                    sourceStream.Close();
                }

                return returnObject;
            }
            catch (Exception error)
            {
                Console.WriteLine($@"Failed to deserialize from '{filePath}': {error.Message}");
                return null;
            }
        }

        /// <summary>
        /// Serializes an object to a file.
        /// </summary>
        /// <param name="source">The source object.</param>
        /// <param name="filePath">The file path.</param>
        /// <returns>A <see cref="bool"/> indicating success.</returns>
        private static bool SerializeObject(object source, string filePath)
        {
            try
            {
                string content;
                using (var sourceStream = new MemoryStream())
                {
                    var sourceFormatter = new BinaryFormatter();
                    sourceFormatter.Serialize(sourceStream, source);
                    var sourceArray = sourceStream.ToArray();
                    content = Encoding.Default.GetString(sourceArray);
                }

                if (!string.IsNullOrEmpty(content))
                {
                    using (var writer = new BinaryWriter(File.Open(filePath, FileMode.Create), Encoding.Default))
                    {
                        writer.Write(content);
                    }
                }

                return true;
            }
            catch (Exception error)
            {
                Console.WriteLine($@"Failed to serialize '{source}' to '{filePath}': {error.Message}");
                return false;
            }
        }

        #endregion // Serializing

        #region Initial Setup

        /// <summary>
        /// Constructs all rooms with their door paths, images, and text.
        /// </summary>
        private void ConstructRooms()
        {
            // Read room image data
            if (!File.Exists(DatFile))
            {
                this.ConstructRoomImages("Images", ".jpg");
            }

            if (DeserializeObject(DatFile) is RoomImages dat)
            {
                this.roomImages = dat;
                for (var r = 0; r <= 45; r++)
                {
                    var desc = RoomText.GetRoomDesc(r);
                    var doors = DoorMaps.GetRoomDoors(r);
                    var img = this.roomImages.GetRoomImage(r);
                    var txt = RoomText.GetRoomText(r);
                    this.Rooms.Add(new MazeRoom(r, img, doors, txt, desc));
                }
            }
            else
            {
                Console.WriteLine(@"Error reading image data, quitting.");
                this.ExitMaze();
            }
        }

        /// <summary>
        /// Constructs a data file from a directory of images.
        /// </summary>
        /// <param name="path">The directory path.</param>
        /// <param name="ext">The image extension.</param>
        private void ConstructRoomImages(string path, string ext)
        {
            var dat = new RoomImages();
            for (var r = 0; r <= 45; r++)
            {
                var imgPath = System.IO.Path.Combine(path, $"room{r:00}{ext}");
                if (File.Exists(imgPath))
                {
                    var img = new BitmapImage(new Uri(imgPath, UriKind.RelativeOrAbsolute));
                    var encoder = new JpegBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create(img));
                    using (var ms = new MemoryStream())
                    {
                        encoder.Save(ms);
                        dat.ImageData.Add(ms.ToArray());
                    }
                }
            }

            if (!dat.ImageData.Any() || !SerializeObject(dat, DatFile))
            {
                Console.WriteLine(@"Failed to serialize images, quitting.");
                this.ExitMaze();
            }
        }

        #endregion // Initial Setup

        #region Gameplay

        /// <summary>
        /// Starts the maze.
        /// </summary>
        private void StartMaze()
        {
            // Text display
            this.ShowMessageText = false;
            this.ShowRoomText = true;

            // Reset path tracking
            this.pathComplete = false;
            this.CurrentPath.Clear();

            // Go to entryway
            this.GoToRoom(0);
        }

        /// <summary>
        /// Handle interface and gameplay state after entering a new room: add room to path,
        /// construct links to doors, and evaluate the current path to see if we've solved the maze.
        /// </summary>
        private void OnRoomEntered()
        {
            // Add to path if new
            if (this.CurrentRoom?.Number > 0 && (this.CurrentPath?.All(r => r.Id != this.CurrentRoom.Id) ?? false))
            {
                this.CurrentPath.Add(this.CurrentRoom);
            }

            // Add door links
            this.ConstructRoomDoors(this.CurrentRoom);

            // Evaluate path
            if (this.CurrentPath?.Any() ?? false)
            {
                // Truncate path if we're backtracking
                while ((this.CurrentPath?.Any() ?? false) && this.CurrentRoom != this.CurrentPath.Last())
                {
                    this.CurrentPath.RemoveAt(this.CurrentPath.Count - 1);
                }

                // For some reason the collection gets truncated to the selected item's visible index, not its actual index??
                Thread.Sleep(100);

                // Check to see if we've travelled from the entry to the center and back
                const int EntranceRoom = 1;
                const int MiddleRoom = 45;
                const int ShortestPath = 16;
                if (!this.pathComplete && this.CurrentPath.Any(r => r.Number == MiddleRoom) && this.CurrentRoom.Number == EntranceRoom)
                {
                    // Maze solved, calculate path length
                    this.pathComplete = true;

                    // Be generous and calculate from the last time we were in the entry room before reaching the center
                    var firstindex = 0;
                    for (var i = firstindex; i < this.CurrentPath.Count - 1; i++)
                    {
                        if (this.CurrentPath[i].Number == EntranceRoom)
                        {
                            firstindex = i;
                        }
                    }

                    var pathLength = this.CurrentPath.Count - firstindex;
                    this.ShowMessageText = true;
                    this.ShowRoomText = false;
                    this.MessageText =
                        $"Congratulations, your trip to the center of the maze and back took {pathLength} steps.";

                    // Shortest legal path is 16 steps
                    if (pathLength == ShortestPath)
                    {
                        this.MessageText += $"\nYou have found the shortest path!";
                    }

                    if (pathLength < ShortestPath)
                    {
                        this.MessageText += "\nCheater!!";
                    }
                }
            }
        }

        /// <summary>
        /// Restart the maze.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event arguments.</param>
        private void OnRestartButtonClick(object sender, RoutedEventArgs e)
        {
            // Maybe prompt first
            this.StartMaze();
        }

        /// <summary>
        /// Handles exit button.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event arguments.</param>
        private void OnExitButtonClick(object sender, RoutedEventArgs e)
        {
            this.ExitMaze(allowCancel: true);
        }

        /// <summary>
        /// Quits the app.
        /// </summary>
        /// <param name="allowCancel">Whether to allow the user to cancel closing the app.</param>
        private void ExitMaze(bool allowCancel = false)
        {
            if (allowCancel)
            {
                // Prompt for confirmation
            }

            this.Close();
        }

        #endregion // Gameplay

        #region Navigation

        /// <summary>
        /// Constructs paths for each of the room's usable doors.
        /// </summary>
        /// <param name="room">The room.</param>
        private void ConstructRoomDoors(MazeRoom room)
        {
            // Clear previous paths
            this.DoorGrid.Children.Clear();

            // Construct new paths
            if (room?.Doors?.Any() ?? false)
            {
                foreach (var doorMap in room.Doors)
                {
                    // For clarity:
                    var imgPath = doorMap.Key;
                    var doorNum = doorMap.Value;

                    var pathColor = Debugger.IsAttached ? Colors.Yellow : Colors.Transparent;

                    // Have to do it this way since there's no Geometry.TryParse() !
                    try
                    {
                        var doorPath = new Path
                                           {
                                               Data = Geometry.Parse(imgPath),
                                               Fill = new SolidColorBrush(pathColor),
                                               Opacity = 0.25
                                           };

                        // Hand cursor, except for hidden door in room 29
                        if (!(room.Number == 29 && doorNum == 17))
                        {
                            doorPath.Cursor = Cursors.Hand;
                        }

                        // Add description tooltip if we've visited the room before
                        if (this.CurrentPath.Any(r => r.Number == doorNum))
                        {
                            doorPath.ToolTip = this.Rooms.FirstOrDefault(r => r.Number == doorNum)?.Description;
                        }

                        // Add door link
                        doorPath.MouseUp += (s, e) =>
                            {
                                if (e.ChangedButton == MouseButton.Left && e.ClickCount == 1)
                                {
                                    this.GoToRoom(doorNum);
                                }
                            };

                        // Place on grid
                        this.DoorGrid.Children.Add(doorPath);
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine($@"Error creating path: {error.Message}.");
                    }
                }
            }
        }

        /// <summary>
        /// Sets the current room to a copy of the specified room, so we can handle room revisiting
        /// </summary>
        /// <param name="roomNum">The room number.</param>
        private void GoToRoom(int roomNum)
        {
            if (roomNum >= 0 && roomNum < this.Rooms.Count)
            {
                this.CurrentRoom = this.Rooms[roomNum].GetInstance();
            }
        }

        /// <summary>
        /// Navigation buttons.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event arguments.</param>
        private void OnNavButtonClick(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(this.NavPrev))
            {
                this.GoToRoom(this.CurrentRoom.Number - 1);
            }
            else if (sender.Equals(this.NavNext))
            {
                this.GoToRoom(this.CurrentRoom.Number + 1);
            }
        }

        /// <summary>
        /// Navigation combo box.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event arguments.</param>
        private void OnNavBoxSelection(object sender, RoutedEventArgs e)
        {
            if (sender is ComboBox combo && combo.SelectedItem is MazeRoom room && room.Number != this.CurrentRoom.Number)
            {
                this.GoToRoom(room.Number);
            }
        }

        /// <summary>
        /// Scroll to current room.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event arguments.</param>
        private void OnPathHistoryChanged(object sender, RoutedEventArgs e)
        {
            if (sender is ListView lv)
            {
                lv.ScrollIntoView(lv.SelectedItem);
            }
        }

        #endregion // Navigation

        #endregion // Methods

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion // INotifyPropertyChanged        
    }
}