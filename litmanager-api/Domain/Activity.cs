using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace litmanager_api.Domain
{
    public class Activity
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public ActivityType ActivityType { get; set; }
        public int MaxUsers { get; set; }

        public ICollection<UserActivity> UserActivities { get; set; }
    }
}
