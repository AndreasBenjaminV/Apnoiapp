using System;
using System.Collections.Generic;
using System.Text;

namespace Apnoiapp.Models
{
    public class UserModel
    {
        public string Id { get; set; }
        public string Age { get; set; }
        public string UserName { get; set; }
        public string UserFatherLastName { get; set; }
        public string UserMatherLastName { get; set; }
        public string UserRut { get; set; }
        public string Password { get; set; }
        public string MailAddress { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public string Licence { get; set; }
        public string ShirtSize { get; set; }

        private static int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }
    }
}
