using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public DateTime DateOfBirth { get; set; }
        public bool IsAdmin { get; set; }
        public Guid UserTypeId { get; set; }

        [ForeignKey(nameof(UserTypeId))]
        public UserType UserType { get; set; }
        public ICollection<UserActivity> UserActivities { get; set; }
        [NotMapped]
        public string FullName { get
            {
                return FirstName + " " + LastName;
            } 
        }
    }
}
