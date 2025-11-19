using MediaPlayerPOC.Common.Specifications.Interfaces;
using MediaPlayerPOC.DigitalFormat.DigitalFormats.MP3;
using MediaPlayerPOC.DigitalFormat.DigitalFormats.Mp4;
using MediaPlayerPOC.DigitalFormat.DigitalFormats.Photo;

namespace MediaPlayerPOC.Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Enum.TryParse<MediaType>(input, out var mediaType);
            IMedia media;
            switch(mediaType)
            {
                case MediaType.Mp3:
                    media = new Mp3Media();
                    break;
                case MediaType.Mp4:
                    media = new Mp4Media();
                    break;
                case MediaType.JPG:
                    media = new PhotoMedia();
                    break;
            }

            IMediaPlayer player = null;
            switch(mediaType)
            {
                case MediaType.Mp3:
                    player = new Mp3MediaPlayer();
                    break;
                case MediaType.Mp4:
                    player = new Mp4MediaPlayer();
                    break;
                case MediaType.JPG:
                    player = new PhotoMediaPlayer();
                    break;
            }
        }
    }
}
