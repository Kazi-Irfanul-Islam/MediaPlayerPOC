using MediaPlayerPOC.Common.Specifications.Interfaces;
using System;
using System.Threading;

namespace MediaPlayerPOC.DigitalFormat.DigitalFormats.MP3
{
    public class Mp3Media : IMedia, IDuratableType 
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public string Extension { get; set; }
        public DateTime CreatedDate { get; set; }
        public Timer Duration { get; set; }

        public string Author { get; set; }

        public byte[] MediaData { get; set; }
    }

    public enum MediaType
    {
        Mp3,
        Mp4,
        JPG,
    }
}