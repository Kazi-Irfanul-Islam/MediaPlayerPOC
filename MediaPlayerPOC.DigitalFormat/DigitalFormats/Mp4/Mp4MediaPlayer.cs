using MediaPlayerPOC.Common.Specifications.Interfaces;
using System;
using System.Collections.Generic;

namespace MediaPlayerPOC.DigitalFormat.DigitalFormats.Mp4
{
    public class Mp4MediaPlayer : IMediaPlayer, IPlayableMediaActions, ILocalStreamableMediaPlayer
    {
        public void Play(IMedia media)
        {
            Console.WriteLine($"Playing Mp4: {media.Name} directed by {(media as Mp4Media)?.Director}");
        }
        public void Pause()
        {
            throw new NotImplementedException();
        }
        public void Stop()
        {
            throw new NotImplementedException();
        }

        public IList<IMedia> GetMedias()
        {
            throw new NotImplementedException();
        }

        IMedia ILocalStreamableMediaPlayer.Play(IMedia mediaObj)
        {
            throw new NotImplementedException();
        }
    }
}
