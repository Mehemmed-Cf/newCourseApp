using DomainLayer.Models;
using RepositoryLayer.Repositories.Interfaces;
using RepositoryLayer.Repositories;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;
        private int _count = 1;

        public TeacherService()
        {
            _teacherRepository = new TeacherRepository();
        }

        public void Create(Teacher teacher)
        {
            teacher.Id = _count++;
            _teacherRepository.Create(teacher);
            _count++;
        }

        List<Teacher> ITeacherService.GetAll() => _teacherRepository.GetAll();

        public List<Teacher> Search(string searchText)
        {
            return _teacherRepository.Search(searchText);
        }
    }
}
