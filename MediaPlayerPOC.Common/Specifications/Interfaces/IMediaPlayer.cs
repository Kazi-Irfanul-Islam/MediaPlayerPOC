using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayerPOC.Common.Specifications.Interfaces
{
    public interface IMediaPlayer
    {
        void Play(IMedia media);
        IList<IMedia> GetMedias();


    }

    public interface  IPlayableMediaActions
    {
        void Pause();
        void Stop();
    }

    public interface ILocalStreamableMediaPlayer
    {
        IMedia Play(IMedia mediaObj);
    }
    public interface IStaticMediaPlayer
    {
        IMedia Display(IMedia mediaObj);
    }
}
