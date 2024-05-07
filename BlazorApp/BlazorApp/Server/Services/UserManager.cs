using BlazorApp.Server.Interfaces;
using BlazorApp.Server.Models;
using BlazorApp.Shared.Models;
using Microsoft.EntityFrameworkCore;
namespace BlazorApp.Server.Services
{
    public class UserManager : IUserManager
    {
        readonly DatabaseContext _dbContext = new();

        public UserManager(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        //To get all data of all users
        public List<UserModel> GetUserDetails()
        {
            try
            {
                return _dbContext.Users.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To add new user data
        public void AddUser(UserModel user)
        {
            try
            {
                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To update existing user data
        public void UpdateUserDetails(UserModel user)
        {
            try
            {
                _dbContext.Entry(user).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To get data of a single user
        public UserModel GetUserData(int id)
        {
            try
            {
                UserModel? user = _dbContext.Users.Find(id);
                if (user != null)
                {
                    return user;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        //To delete single user
        public void DeleteUser(int id)
        {
            try
            {
                UserModel? user = _dbContext.Users.Find(id);
                if (user != null)
                {
                    _dbContext.Users.Remove(user);
                    _dbContext.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}