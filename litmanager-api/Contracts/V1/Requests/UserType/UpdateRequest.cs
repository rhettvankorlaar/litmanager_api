using litmanager_api.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace litmanager_api.Contracts.V1.Requests.UserType
{
    public class UpdateRequest
    {
        public string Type { get; set; }
    }
}
