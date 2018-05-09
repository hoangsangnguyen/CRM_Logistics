﻿using API.Entities;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public interface IUnitRepository : IGenericRepository<Unit, UnitDto, UnitDto>
    {
    }
}
