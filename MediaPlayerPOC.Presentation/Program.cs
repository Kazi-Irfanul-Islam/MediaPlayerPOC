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
            IMedia media = null;
            switch(mediaType)
            {
                case MediaType.Mp3:
                    media = new Mp3Media
                    {
                        Name = "My Awesome MP3",
                        Author = "The AI",
                        Size = "10MB"
                    };
                    break;
                case MediaType.Mp4:
                    media = new Mp4Media
                    {
                        Name = "My Awesome MP4",
                        Director = "The AI Director",
                        Size = "50MB"
                    };
                    break;
                case MediaType.JPG:
                    media = new PhotoMedia
                    {
                        Name = "My Awesome JPG",
                        Size = "5MB"
                    };
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

            player?.Play(media);
        }
    }
}
