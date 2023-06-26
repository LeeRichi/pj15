namespace MediaPlayer.src.Domain.Core
{
    public class Audio : MediaFile
    {
        public Audio(string fileName, string filePath, TimeSpan duration, double speed) : base(fileName, filePath, duration, speed)
        {
            System.Console.WriteLine(fileName, filePath, duration, speed);
        }
    }
}