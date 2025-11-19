using MediaPlayerPOC.Common.Specifications.Interfaces;
using System;
using System.Threading;

namespace MediaPlayerPOC.DigitalFormat.DigitalFormats.Mp4
{
    public class Mp4Media : IMedia, IDuratableType
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public string Extension { get; set; }
        public DateTime CreatedDate { get; set; }
        public Timer Duration { get; set; }
        public string Director { get; set; }

        public byte[] MediaData { get; set; }

    }
}