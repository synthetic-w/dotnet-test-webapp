using BlazorApp.Shared.Models;
namespace BlazorApp.Server.Interfaces
{
    public interface IUserManager
    {
        public List<User> GetUserDetails();

        public void AddUser(User user);

        public void UpdateUserDetails(User user);

        public User GetUserData(int id);

        public void DeleteUser(int id);
    }
}