using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Shared.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public DateTime RegistrationDate { get; set; }
        public int UserRating { get; set; } = 0;
        public string PhoneNumber { get; set; } = null!;
        public string EmailId { get; set; } = null!;
    }
}
