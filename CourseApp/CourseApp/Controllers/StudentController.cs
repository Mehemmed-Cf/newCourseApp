using DomainLayer.Models;
using ServiceLayer.Helpers.Extensions;
using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Controllers
{
    public class StudentController
    {
        private readonly IStudentService _studentService;

        public StudentController()
        {
            _studentService = new StudentService();
        }

        public void Create()
        {
            ConsoleColor.White.WriteConsole("Add Student full name:");
            string fullname = Console.ReadLine();

            ConsoleColor.White.WriteConsole("Add Student Address:");
            string address = Console.ReadLine();

            Student student = new()
            {
                FullName = fullname,
                Address = address

            };

            _studentService.Create(student);
            ConsoleColor.Green.WriteConsole("Student created succesfully");

        }
        public void GetAll()
        {
            foreach (Student student in _studentService.GetAll())
            {
                string data = $"student Id: {student.Id} , student Fullname: {student.FullName} , student address: {student.Address}";
                ConsoleColor.DarkMagenta.WriteConsole(data);
            }
        }

        public void Search()
        {

            ConsoleColor.White.WriteConsole("Add search text");
            string search = Console.ReadLine();
            foreach (Student student in _studentService.Search(search))
            {
                string data = $"student Id: {student.Id} , student Fullname: {student.FullName} , student address: {student.Address}";
                ConsoleColor.DarkMagenta.WriteConsole(data);
            }
        }
    }
}
