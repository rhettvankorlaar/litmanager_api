using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace litmanager_api.Domain
{
    public class User
    {
        [Key]
        public string Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PasswordHash { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsAdmin { get; set; }
        public UserType UserType { get; set; }
        public ICollection<UserActivity> UserActivities { get; set; }
    }
}
