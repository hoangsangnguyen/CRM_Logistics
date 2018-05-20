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
    [Route("api/Departments")]
    public class DepartmentsController : Controller
    {
        private readonly IDepartmentsRepository _repository;
        private readonly DatabaseContext _context;
        public DepartmentsController(IDepartmentsRepository repository, DatabaseContext context)
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
                result.Message = "Get Departments failed";
                return BadRequest(result);
            }

            result.Success = true;
            result.Message = "Get Departments succeed";
            result.Object = dtoFromRepo;

            return Ok(result);
        }
    }
}