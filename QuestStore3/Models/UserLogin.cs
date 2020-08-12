using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace QuestStore3.Models
{
    public class UserLogin
    {
        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Password { get; set; }
    }

}

