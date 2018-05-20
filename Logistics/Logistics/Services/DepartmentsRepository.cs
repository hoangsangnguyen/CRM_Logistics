using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logistics.Entities;
using Logistics.Models;

namespace Logistics.Services
{
    public class DepartmentsRepository : GenericRepository<Department, DepartmentDto, DepartmentDto>, IDepartmentsRepository
    {
        private DatabaseContext _context;

        public DepartmentsRepository(DatabaseContext context) : base(context)
        {
            _context = context;
        }
    }
}
