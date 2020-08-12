using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuestStore3.Models
{
    public enum Status
    {
        Active, Inactive, Archival
    }
    public enum Role
    {
        Admin, Mentor, Student
    }

    public class User
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public int PhoneNumber { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.Password)]
        
        public string Password { get; set; }

        [Required, Compare(nameof(Password), ErrorMessage = "Password don't match, please try again")]
        [NotMapped]
        [DataType(DataType.Password)]
        public string ConfirmPassword  { get; set; }
        
        [Required(ErrorMessage = "This field is required")]
        public string Adress { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.PostalCode)]
        public int Postcode { get; set; }

        public DateTime RegistrationDate { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public Role Role { get; set; }
        public Status Status { get; set; }
        [NotMapped]
        public bool CheckBoxAnswer { get; set; }


        //public ICollection<Group> Group { get; set; }
        public IList<Quest> Quest { get; set; }
        public IList<Bonus> Bonus { get; set; }
    }
}
