using MediaPlayer.Domain.src.RepositoryInterface;

namespace MediaPlayer.src.Infrastructure.Repository
{
    public class MediaRepository : IMediaRepository
    {
        private readonly List<string> _files = new List<string>();

        public void CreateNewFile(string fileName, string filePath, TimeSpan duration)
        {
            string file = $"{fileName} ({filePath}) [{duration}]";
            _files.Add(file);
            throw new NotImplementedException();
        }

        public void DeleteFileById(int fileId)
        {   
            if (fileId >= 0 && fileId < _files.Count)
            {
                _files.RemoveAt(fileId);
            }
            else
            {
                throw new ArgumentException("Invalid file ID.");
            }
            throw new NotImplementedException();
        }

        public List<string> GetAllFiles()
        {
            return _files;
            throw new NotImplementedException();
        }

        public void GetFileById(int fileId)
        {
            throw new NotImplementedException();
        }

        public void Pause(int fileId)
        {
            throw new NotImplementedException();
        }

        public void Play(int fileId)
        {
            throw new NotImplementedException();
        }

        public void Stop(int fileId)
        {
            throw new NotImplementedException();
        }

        void IMediaRepository.GetAllFiles()
        {
            throw new NotImplementedException();
        }
    }
}