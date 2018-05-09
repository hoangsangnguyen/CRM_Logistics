using API.Entities;
using API.Infrastructure;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class AirExpRepository : GenericRepository<AirExp, AirExpDto, AirExpForCreationDto>, IAirExpRepository
    {
        private DatabaseContext _context;
        private readonly UserManager<UserEntity> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AirExpRepository(DatabaseContext context,
             UserManager<UserEntity> userManager,
            IHttpContextAccessor httpContextAccessor) : base(context)
        {
            _context = context;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;

        }
    }
}
