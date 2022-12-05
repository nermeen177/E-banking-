using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_banking.Models
{

    public class Person
    {
        [Required(ErrorMessage = "You have to enter your name .")]
        [Display(Name = "UserName")]
        [StringLength(maximumLength: 50, ErrorMessage = "Maximum 50 characters.")]
        public string username { get; set; }

        [Required(ErrorMessage = "You have to enter your Password .")]
        public string password { get; set; }
    }
}