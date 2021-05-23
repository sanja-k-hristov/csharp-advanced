using QuizzApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzApp.Services
{
    public static class Database
    {
        public static Student ActiveStudent { get; set; }
        public static Teacher ActiveTeacher { get; set; }

        public static void activeSessionStudent(Student student)
        {
            ActiveStudent = student;
        }

        public static void activeSessionTeacher(Teacher teacher)
        {
            ActiveTeacher = teacher;
        }
    }
}
