using BlazorApp.Server.Interfaces;
using BlazorApp.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserManager _userManager;

        public UserController(IUserManager iUser)
        {
            _userManager = iUser;
        }

        [HttpGet]
        [Route("GetDetails")]
        public async Task<List<User>> Get()
        {
            return await Task.FromResult(_userManager.GetUserDetails());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            User user = _userManager.GetUserData(id);

            if (user != null)
            {
                return Ok(user);
            }
            return NotFound();
        }

        [HttpPost]
        public void Post(User user)
        {
            _userManager.AddUser(user);
        }

        [HttpPut]
        public void Put(User user)
        {
            _userManager.UpdateUserDetails(user);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userManager.DeleteUser(id);
            return Ok();
        }
    }
}