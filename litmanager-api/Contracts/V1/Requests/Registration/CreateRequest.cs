using litmanager_api.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace litmanager_api.Contracts.V1.Requests.Registration
{
    public class CreateRequest
    {
        [Required(ErrorMessage = "Id is verplicht.")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Email is verplicht.")]
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Guid UserTypeId { get; set; }

        [Required(ErrorMessage = "Wachtwoord is verplicht.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Herhaal uw wachtwoord is verplicht.")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

    }
}
