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
    public class NationalitiesController : GenericController<Nationality, NationalityDto, NationalityDto>
    {
        private readonly DatabaseContext _context;
        private readonly INationalitiyRepository _nationalitiyRepository;

        public NationalitiesController(INationalitiyRepository nationalitiyRepository, DatabaseContext context) : base(nationalitiyRepository, context)
        {
            _nationalitiyRepository = nationalitiyRepository;
            _context = context;
        }

    }
}
