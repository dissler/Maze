namespace Maze.Common.Data
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Windows.Media.Imaging;

    /// <summary>
    /// The images for each room.
    /// </summary>
    [Serializable]
    public class RoomImages
    {
        #region Fields

        /// <summary>
        /// Gets or sets the list of room images.
        /// </summary>
        public List<byte[]> ImageData { get; set; } = new List<byte[]>();

        #endregion // Fields

        #region Methods

        /// <summary>
        /// Returns the image for the given room number.
        /// </summary>
        /// <param name="roomNum">The room number.</param>
        /// <returns>A <see cref="BitmapImage"/>.</returns>
        public BitmapImage GetRoomImage(int roomNum)
        {
            var returnImage = new BitmapImage();
            if (roomNum >= 0 && roomNum < this.ImageData.Count)
            {
                var ms = new MemoryStream(this.ImageData[roomNum]);
                returnImage.BeginInit();
                returnImage.StreamSource = ms;
                returnImage.EndInit();
            }

            return returnImage;
        }

        #endregion // Methods
    }
}
