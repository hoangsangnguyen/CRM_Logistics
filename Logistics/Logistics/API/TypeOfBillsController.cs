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
    [Route("api/TypeOfBills")]
    public class TypeOfBillsController : Controller
    {
        private readonly ITypeOfBillsRepository _repository;
        private readonly DatabaseContext _context;
        public TypeOfBillsController(ITypeOfBillsRepository repository, DatabaseContext context)
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
                result.Message = "Get Type of bills failed";
                return BadRequest(result);
            }

            result.Success = true;
            result.Message = "Get Type of bills succeed";
            result.Object = dtoFromRepo;

            return Ok(result);
        }
    }
}