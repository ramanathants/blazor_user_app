﻿// Models/User.cs
using System.ComponentModel.DataAnnotations;

namespace BlazorUserApp.Models
{
    public class User
    {
       
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }
}
