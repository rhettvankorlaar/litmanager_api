using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace litmanager_api.Contracts.V1.Responses.User
{
    public class GetResponse
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid UserTypeId { get; set; }
        public Domain.UserType UserType { get; set; }
        public bool IsEnabled { get; set; }
        public string FullName {get; set;}
    }
}
