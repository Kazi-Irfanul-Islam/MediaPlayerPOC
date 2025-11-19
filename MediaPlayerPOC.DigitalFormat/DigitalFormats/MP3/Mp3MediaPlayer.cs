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

        public IMedia Play(IMedia m)
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
