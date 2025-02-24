namespace VideoPlayer
{
    public interface IPlayable
    {
        void Play();
    }

    public class MusicPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing music...");
        }
    }

    public class VideoPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing video...");
        }
    }

    public class Program
    {
        public static void Main()
        {
            IPlayable musicPlayer = new MusicPlayer();
            IPlayable videoPlayer = new VideoPlayer();

            musicPlayer.Play(); // Output: Playing music...
            videoPlayer.Play(); // Output: Playing video...
        }
    }
}
