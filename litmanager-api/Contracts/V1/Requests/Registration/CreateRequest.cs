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
        [Required(ErrorMessage = "School id is verplicht.")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Email is verplicht.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Voornaam is verplicht.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Achternaam is verplicht.")]
        public string LastName { get; set; }

        public Guid UserTypeId { get; set; }

    }
}
