using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CST8359_Assignment1.Models
{
    public class UserTable
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailEncryptedText { get; set; }
        public string PasswordEncryptedText { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Country { get; set; }
        public string UserType { get; set; }
    }
}