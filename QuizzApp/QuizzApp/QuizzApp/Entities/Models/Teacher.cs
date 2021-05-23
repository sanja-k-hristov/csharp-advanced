using QuizzApp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzApp.Entities.Models
{
    public class Teacher : User
    {
        public Roles Role { get; set; }

        public Teacher()
        {

        }

        public Teacher(string firstName, string lastName, string username, string password)
            : base(firstName, lastName, username, password)
        {
            Role = Roles.Teacher;
        }
    }
}
