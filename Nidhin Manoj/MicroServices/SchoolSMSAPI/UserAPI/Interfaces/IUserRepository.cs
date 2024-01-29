using UserAPI.Models;

namespace UserAPI.Interfaces
{
    public interface IUserRepository
    {
        void Register(User user);
        User Validate(string username, string password);
        void EditUser(User user);
    }
}
