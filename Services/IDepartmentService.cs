using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorFront358.Models;

namespace BlazorFront358.Services
{
    public interface IDepartmentService
    {
            Task<IEnumerable<Department>> GetAll();
         Task<Department> GetById(int id);
    }
}