using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ITeacherService
    {
        void Create(Teacher teacher);
        List<Teacher> GetAll();
        List<Teacher> Search(string searchText);
    }
}
