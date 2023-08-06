using DomainLayer.Models;
using RepositoryLayer.Repositories;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private int _count = 1;

        public StudentService()
        {
            _studentRepository = new StudentRepository();
        }

        public void Create(Student student)
        {
            student.Id = _count++;
            _studentRepository.Create(student);
            _count++;
        }

        public List<Student> GetAll() => _studentRepository.GetAll();

        public List<Student> Search(string searchText)
        {
            return _studentRepository.Search(searchText);
        }
    }
}
