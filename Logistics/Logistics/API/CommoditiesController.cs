using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logistics.Entities;
using Logistics.Models;
using Logistics.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Logistics.API
{
    [Produces("application/json")]
    [Route("api/Commodities")]
    public class CommoditiesController : Controller
    {
        private readonly ICommoditiesRepository _repository;
        private readonly DatabaseContext _context;
        public CommoditiesController(ICommoditiesRepository repository, DatabaseContext context)
        {
            _repository = repository;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            BaseResultDto result = new BaseResultDto();
            var dtoFromRepo = await _repository.GetAllAsync();
            if (dtoFromRepo == null)
            {
                result.Success = false;
                result.Message = "Get Commodities failed";
                return BadRequest(result);
            }

            result.Success = true;
            result.Message = "Get Commodities succeed";
            result.Object = dtoFromRepo;

            return Ok(result);
        }
    }
}