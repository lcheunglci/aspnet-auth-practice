﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace LCI.IDP.UserRegistration
{
    public class RegisterUserViewModel
    {
        [MaxLength(200)]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [MaxLength(200)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [MaxLength(250)]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        [MaxLength(250)]
        [Display(Name = "Given name")]
        public string GivenName { get; set; }

        [Required]
        [MaxLength(250)]
        [Display(Name = "Family name")]
        public string FamilyName { get; set; }

        [Required]
        [MaxLength(250)]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [MaxLength(2)]
        [Display(Name = "Country")]
        public string Country { get; set; }

        public SelectList CountryCodes { get; set; } = new SelectList(
            new[]
            {
                new { Id = "BE", Value = "Belgium"},
                new { Id = "US", Value = "United States of America"},
                new { Id = "IN", Value = "India"},
                new { Id = "CA", Value = "Canada"} },
                "Id",
                "Value");

        public string ReturnUrl { get; set; }


    }
}
