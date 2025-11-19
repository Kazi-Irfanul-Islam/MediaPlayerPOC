using System;

namespace MediaPlayerPOC.Common.Specifications.Interfaces
{
    public interface IMedia
    {
        string Name { get; set; }
        string Size { get; set; }
        string Extension { get; set; }

        DateTime CreatedDate { get; set; }

        byte[] MediaData { get; set; }


    }
}