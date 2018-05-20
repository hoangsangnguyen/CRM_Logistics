using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Logistics.Entities;
using Logistics.Models;
using Logistics.Services;
using Microsoft.AspNetCore.Mvc;

namespace Logistics.Controllers
{
    public class AirexpsController : BaseController
    {
        private readonly IAirexpsRepository _repository;
        private readonly DatabaseContext _context;
        public AirexpsController(IAirexpsRepository repository, DatabaseContext context)
        {
            _repository = repository;
            _context = context;
        }

        public IActionResult Index()
        {
            return RedirectToAction("List");
        }

        public IActionResult List()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            BaseResultDto result = new BaseResultDto();
            var dtoFromRepo = await _repository.GetAllAsync();
            if (dtoFromRepo == null)
            {
                result.Success = false;
                result.Message = "Get Airexps failed";
                return BadRequest(result);
            }

            result.Success = true;
            result.Message = "Get Airexps succeed";
            result.Object = dtoFromRepo;

            return Ok(result);
        }

        public IActionResult Create()
        {
            AirExpForCreationDto model = new AirExpForCreationDto()
            {
                created = DateTime.Now.Date,
                etd = DateTime.Now.Date,
                eta = DateTime.Now.Date,
                flyDate = DateTime.Now.Date
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AirExpForCreationDto dto)
        {
            Console.WriteLine(dto);

            var id = await _repository.CreateAsync(dto);
            if (id == Guid.Empty)
            {
                Console.WriteLine("Create failed");
            }
            else
            {
                Console.WriteLine("Create succeed");
            }


            return RedirectToAction("List");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var dto = await _repository.GetSingleAsync(id);
            if (dto == null)
            {
                return RedirectToAction("List");
            }

            var model = Mapper.Map<AirExpForCreationDto>(dto);
            return View(model);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(AirExpForCreationDto dto)
        {
            var id = await _repository.EditAsync(dto.Id, dto);
            if (id == Guid.Empty)
            {
                return View(dto);
            }

            return RedirectToAction("List");
        }
    }
}