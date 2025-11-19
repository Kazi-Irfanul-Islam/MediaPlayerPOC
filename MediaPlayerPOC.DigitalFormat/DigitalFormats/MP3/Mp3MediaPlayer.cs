using MediaPlayerPOC.Common.Specifications.Interfaces;
using System;
using System.Collections.Generic;

namespace MediaPlayerPOC.DigitalFormat.DigitalFormats.MP3
{
    public class Mp3MediaPlayer : IMediaPlayer, IPlayableMediaActions, ILocalStreamableMediaPlayer
    {
        

        public IList<IMedia> GetMedias()
        {
            throw new NotImplementedException();
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Play(IMedia media)
        {
            Console.WriteLine($"Playing Mp3: {media.Name} by {(media as Mp3Media)?.Author}");
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        IMedia ILocalStreamableMediaPlayer.Play(IMedia mediaObj)
        {
            throw new NotImplementedException();
        }
    }
}
