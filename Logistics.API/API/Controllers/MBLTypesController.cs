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
    public class MBLTypesController : GenericController<MBLType, MBLTypeDto, MBLTypeDto>
    {
        private readonly DatabaseContext _context;
        private readonly IMBLTypeRepository _mBLTypeRepository;

        public MBLTypesController(IMBLTypeRepository mBLTypeRepository, DatabaseContext context) : base(mBLTypeRepository, context)
        {
            _mBLTypeRepository = mBLTypeRepository;
            _context = context;
        }

    }
}
