using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace litmanager_api.Contracts.V1.Responses.UserType
{
    public class GetResponse
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
    }
}
