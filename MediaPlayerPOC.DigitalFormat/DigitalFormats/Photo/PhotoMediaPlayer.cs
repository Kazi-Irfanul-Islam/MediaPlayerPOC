using MediaPlayerPOC.Common.Specifications.Interfaces;
using System;
using System.Collections.Generic;

namespace MediaPlayerPOC.DigitalFormat.DigitalFormats.Photo
{
    public class PhotoMediaPlayer : IMediaPlayer, IStaticMediaPlayer
    {
        public void Play(IMedia media)
        {
            Console.WriteLine($"Viewing Photo: {media.Name}");
        }

        public IMedia Display(IMedia mediaObj)
        {
            Console.WriteLine($"Displaying Photo: {mediaObj.Name}");
            return mediaObj;
        }

        public IList<IMedia> GetMedias()
        {
            return new List<IMedia>();
        }
    }
}
