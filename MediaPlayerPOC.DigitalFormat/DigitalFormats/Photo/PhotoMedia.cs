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
    }
}