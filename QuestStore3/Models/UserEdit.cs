using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace QuestStore3.Models
{
    public class UserEdit
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Adress { get; set; }
        [DataType(DataType.PostalCode)]
        public int Postcode { get; set; }
        public DateTime RegistrationDate { get; set; }

        public Role Role { get; set; }
        public Status Status { get; set; }
    }
}