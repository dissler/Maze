namespace Maze.Common
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Media.Imaging;

    /// <summary>
    /// A room in the maze.
    /// </summary>
    public class MazeRoom
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MazeRoom"/> class.
        /// </summary>
        /// <param name="number">The room number.</param>
        /// <param name="image">The room's image.</param>
        /// <param name="doors">The room's doors and their xaml path data.</param>
        /// <param name="text">The room's text.</param>
        /// <param name="description">The room's description.</param>
        /// <param name="items">The room's interactable items</param>
        public MazeRoom(
            int number,
            BitmapImage image,
            Dictionary<string, int> doors,
            string text,
            string description = null,
            Dictionary<string, int> items = null)
        {
            this.Description = description ?? $"Room {number}";
            this.Doors = doors;
            this.Image = image;
            this.Id = Guid.NewGuid();
            this.Items = items ?? new Dictionary<string, int>();
            this.Number = number;
            this.Text = text;
        }

        #endregion // Constructors

        #region Properties

        /// <summary>
        /// Gets the room's description.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Gets the room's doors.
        /// </summary>
        public Dictionary<string, int> Doors { get; }

        /// <summary>
        /// Gets the id.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Gets the room's image.
        /// </summary>
        public BitmapImage Image { get; }

        /// <summary>
        /// Gets the room's interactable items.
        /// </summary>
        public Dictionary<string, int> Items { get; }

        /// <summary>
        /// Gets the room's number.
        /// </summary>
        public int Number { get; }

        /// <summary>
        /// Gets the room's text.
        /// </summary>
        public string Text { get; }

        #endregion // Properties

        #region Methods

        /// <summary>
        /// Gets a copy of the room.
        /// </summary>
        /// <returns>The <see cref="MazeRoom"/>.</returns>
        public MazeRoom GetInstance()
        {
            return new MazeRoom(this.Number, this.Image, this.Doors, this.Text, this.Description, this.Items);
        }

        #endregion // Methods
    }
}
