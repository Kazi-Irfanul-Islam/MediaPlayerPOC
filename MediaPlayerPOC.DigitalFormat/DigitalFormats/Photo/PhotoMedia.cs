using MediaPlayerPOC.Common.Specifications.Interfaces;
using System;

namespace MediaPlayerPOC.DigitalFormat.DigitalFormats.Photo
{
    public class PhotoMedia : IMedia
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public string Extension { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte[] MediaData { get; set; }

        public PhotoMedia() {
            Name = "Dummy Photo";
            Size = "2 MB";
            Extension = ".jpg";
            CreatedDate = DateTime.Now;
            MediaData = new byte[50]; // Dummy data
        }
    }
}