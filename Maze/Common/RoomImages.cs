namespace Maze.Common
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

        public List<byte[]> ImageData { get; set; } = new List<byte[]>();

        #endregion // Fields

        #region Methods

        public BitmapImage GetRoomImage(int roomNum)
        {
            var returnImage = new BitmapImage();
            if (roomNum < this.ImageData.Count)
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
