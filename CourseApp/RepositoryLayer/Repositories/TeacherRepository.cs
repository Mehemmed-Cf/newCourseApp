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
    public class TeacherRepository : BaseRepository<Teacher> , ITeacherRepository
    {
        public List<Teacher> Search(string fullname)
        {
            return AppDbContext<Teacher>.datas.Where(m => m.FullName == fullname).ToList();
        }
    }
}
