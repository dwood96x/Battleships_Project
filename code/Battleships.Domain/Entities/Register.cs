﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Battleships.Domain.Entities
{
    public class Register
    {
        [Display(Name = "Username: ")]
        [Required(ErrorMessage = "Username is required")]
        public string username { get; set; }
        [Display(Name = "Password: ")]
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Display(Name = "Email: ")]
        [Required(ErrorMessage = "Email is required")]
        public string email { get; set; }

    }
}