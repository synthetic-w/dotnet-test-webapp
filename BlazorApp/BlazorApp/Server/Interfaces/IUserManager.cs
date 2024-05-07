using BlazorApp.Shared.Models;

namespace BlazorApp.Server.Interfaces
{
    public interface IUserManager
    {
        public List<UserModel> GetUserDetails();

        public void AddUser(UserModel user);

        public void UpdateUserDetails(UserModel user);

        public UserModel GetUserData(int id);

        public void DeleteUser(int id);
    }
}