﻿using API.Entities;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class CommodityRepository : GenericRepository<Commodity, CommodityDto, CommodityDto>, ICommodityRepository
    {
        private DatabaseContext _context;
        private readonly UserManager<UserEntity> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CommodityRepository(DatabaseContext context,
             UserManager<UserEntity> userManager,
            IHttpContextAccessor httpContextAccessor) : base(context)
        {
            _context = context;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;

        }
    }
}