using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace litmanager_api.Domain
{
    public class UserActivity
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public Guid ActivityId { get; set; }
        public Activity Activity { get; set; }
    }
}
