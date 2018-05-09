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
    //[Authorize]
    public class TypeOfBillsController : GenericController<TypeOfBill, TypeOfBillDto, TypeOfBillDto>
    {
        private readonly DatabaseContext _context;
        private readonly ITypeOfBillRepository _typeOfBillRepository;

        public TypeOfBillsController(ITypeOfBillRepository typeOfBillRepository, DatabaseContext context) : base(typeOfBillRepository, context)
        {
            _typeOfBillRepository = typeOfBillRepository;
            _context = context;
        }

    }
}
