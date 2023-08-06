using DomainLayer.Models;
using ServiceLayer.Helpers.Extensions;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Controllers
{
    public class TeacherController
    {

        private readonly ITeacherService _teacherservice;

        public TeacherController()
        {
            _teacherservice = new TeacherService();
        }

        public void Create()
        {
            ConsoleColor.White.WriteConsole("Add Teacher full name:");
            string fullname = Console.ReadLine();

            ConsoleColor.White.WriteConsole("Add Teacher Address:");
            string email = Console.ReadLine();

            Teacher teacher = new()
            {
                FullName = fullname,
                Email = email

            };

            _teacherservice.Create(teacher);
            ConsoleColor.Green.WriteConsole("Teacher created succesfully");

        }
        public void GetAll()
        {
            foreach (Teacher teacher in _teacherservice.GetAll())
            {
                string data = $"teacher Id: {teacher.Id} , teacher Fullname: {teacher.FullName} , teacher address: {teacher.Email}";
                ConsoleColor.DarkMagenta.WriteConsole(data);
            }
        }

        public void Search()
        {
            ConsoleColor.White.WriteConsole("Add search text");
            string search = Console.ReadLine();
            foreach (Teacher teacher in _teacherservice.Search(search))
            {
                string data = $"teacher Id: {teacher.Id} , teacher Fullname: {teacher.FullName} , teacher address: {teacher.Email}";
                ConsoleColor.DarkMagenta.WriteConsole(data);
            }
        }
    }
}
