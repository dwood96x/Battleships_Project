﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Battleships.Models
{
    public class RegisterModel
    {
        [Display(Name = "Username: ")]
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }
        [Display(Name = "Password: ")]
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Email: ")]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

    }
}