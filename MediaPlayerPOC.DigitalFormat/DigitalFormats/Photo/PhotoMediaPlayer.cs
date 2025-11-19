using MediaPlayerPOC.Common.Specifications.Interfaces;
using System;
using System.Collections.Generic;

namespace MediaPlayerPOC.DigitalFormat.DigitalFormats.Photo
{
    public class PhotoMediaPlayer : IMediaPlayer, IStaticMediaPlayer
    {
        public IMedia Display(IMedia mediaObj)
        {
            throw new NotImplementedException();
        }

        public IList<IMedia> GetMedias()
        {
            throw new NotImplementedException();
        }
    }
}
