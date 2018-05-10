using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Models;
using API.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("[controller]")]
    public class DepartmentsController : GenericController<Department, DepartmentDto, DepartmentDto>
    {
        private readonly DatabaseContext _context;
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentsController(IDepartmentRepository departmentRepository, DatabaseContext context) : base(departmentRepository, context)
        {
            _departmentRepository = departmentRepository;
            _context = context;
        }

    }
}
