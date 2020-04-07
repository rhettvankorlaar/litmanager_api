using litmanager_api.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace litmanager_api.Contracts.V1.Requests.User
{
    public class UpdateRequest
    {
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Guid UserTypeId { get; set; }

        public bool IsEnabled { get; set; }

        public bool IsAdmin { get; set; }
    }
}
