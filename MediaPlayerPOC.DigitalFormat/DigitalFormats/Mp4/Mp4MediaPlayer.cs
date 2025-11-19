using MediaPlayerPOC.Common.Specifications.Interfaces;
using System;
using System.Collections.Generic;

namespace MediaPlayerPOC.DigitalFormat.DigitalFormats.Mp4
{
    public class Mp4MediaPlayer : IMediaPlayer, IPlayableMediaActions, ILocalStreamableMediaPlayer
    {
        public IMedia Play(IMedia m)
        {
            throw new NotImplementedException();
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
    }
}
