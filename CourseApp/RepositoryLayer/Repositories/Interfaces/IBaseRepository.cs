using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Common;

namespace RepositoryLayer.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Create(T entity);
        void Edit(T entity);
        void Delete(T entity);
        T GetById(int id);
        List<T> GetAll();

    }
}
