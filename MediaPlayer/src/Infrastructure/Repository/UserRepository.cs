using MediaPlayer.src.Domain.RepositoryInterface;

namespace MediaPlayer.src.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        public UserRepository(){}

        public void AddNewList(string name, int userId)
        {
            Console.WriteLine("Name is added: " + name + ", and the ID is: " + userId);
            // throw new NotImplementedException();
        }

        public void EmptyOneList(int listId, int userId)
        {
            // throw new NotImplementedException();
        }

        public void GetAllList(int userId)
        {
            System.Console.WriteLine();
            // throw new NotImplementedException();
        }

        public void GetListById(int listId)
        {
            throw new NotImplementedException();
        }

        public void RemoveAllLists(int userId)
        {
            throw new NotImplementedException();
        }

        public void RemoveOneList(int listId, int userId)
        {
            throw new NotImplementedException();
        }

    }
}