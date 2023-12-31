﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;

namespace RepositoryLayer.Repositories.Interfaces
{
    public interface ITeacherRepository : IBaseRepository<Teacher>
    {
        List<Teacher> Search(string search);
    }
}
