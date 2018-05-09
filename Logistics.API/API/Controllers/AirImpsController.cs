﻿using System;
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
    public class AirImpsController : GenericController<AirImp, AirImpDto, AirImpForCreationDto>
    {
        private readonly DatabaseContext _context;
        private readonly IAirImpRepository _airImpRepository;

        public AirImpsController(IAirImpRepository airImpRepository, DatabaseContext context) : base(airImpRepository, context)
        {
            _airImpRepository = airImpRepository;
            _context = context;
        }

    }
}
