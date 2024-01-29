using UserAPI.Interfaces;
using UserAPI.Models;

namespace UserAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        List<User> users= new List<User>();
        public void EditUser(User user)
        {
            foreach (var user1 in users) 
            { 
                if(user.UserID == user.UserID) 
                {
                    user1.UserName = user.UserName;
                    user1.Password = user.Password;
                }
            }
        }

        public void Register(User user)
        {
            users.Add(user);
        }

        public User Validate(string username, string password)
        {
            foreach(var user in users)
            {
                if(user.UserName == username && user.Password== password)
                    return user;
            }
            return null;
        }
    }
}
