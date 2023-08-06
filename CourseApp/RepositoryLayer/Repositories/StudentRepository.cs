using DomainLayer.Models;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories
{
    public class StudentRepository : BaseRepository<Student> , IStudentRepository
    {
        public List<Student> Search(string fullname) 
        {
            return AppDbContext<Student>.datas.Where(m => m.FullName == fullname).ToList();
        }
    }
}
