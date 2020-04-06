using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace litmanager_api.Domain
{
    public class UserType
    {
        [Key]
        public Guid Id { get; set; }
        public string Type { get; set; }
    }
}
