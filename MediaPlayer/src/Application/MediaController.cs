using MediaPlayer.src.Business.ServiceInterface;

namespace MediaPlayer.src.Application
{
    public class MediaController
    {
        private readonly IMediaService _mediaService;

        public MediaController(IMediaService mediaService)
        {
            _mediaService = mediaService;
        }

        public void CreateNewFile(string fileName, string filePath, TimeSpan duration)
        {
            _mediaService.CreateNewFile(fileName, filePath, duration);
        }

        public void DeleteFileById(int id)
        {
            _mediaService.DeleteFileById(id);
        }

        public bool GetAllFiles()
        {
            _mediaService.GetAllFiles();
            System.Console.WriteLine("hi");
            return true;
        }

        public void GetFileById(int id)
        {
            _mediaService.GetFileById(id);
        }
    }
}