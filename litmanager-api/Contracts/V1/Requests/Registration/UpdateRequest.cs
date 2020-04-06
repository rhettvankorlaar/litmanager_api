﻿using litmanager_api.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace litmanager_api.Contracts.V1.Requests.Registration
{
    public class UpdateRequest
    {
        [Required(ErrorMessage = "Id is verplicht.")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Email is verplicht.")]
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public UserType UserType { get; set; }
    }
}