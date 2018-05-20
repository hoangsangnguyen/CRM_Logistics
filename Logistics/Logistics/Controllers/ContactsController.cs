using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logistics.Entities;
using Logistics.Models;
using Logistics.Services;
using Microsoft.AspNetCore.Mvc;

namespace Logistics.Controllers
{
    public class ContactsController : BaseController
    {
        private readonly IContactsRepository _repository;
        private readonly DatabaseContext _context;
        public ContactsController(IContactsRepository repository, DatabaseContext context)
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
                result.Message = "Get Contacts failed";
                return BadRequest(result);
            }

            result.Success = true;
            result.Message = "Get Contacts succeed";
            result.Object = dtoFromRepo;

            return Ok(result);
        }

        public IActionResult Create()
        {
            ContactForCreationDto model = new ContactForCreationDto();
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ContactForCreationDto dto)
        {
            var id = await _repository.CreateAsync(dto);
            if (id == Guid.Empty)
            {
                Console.WriteLine("Create contact failed");
            }
            else
            {
                Console.WriteLine("Create contact succeed");
            }

            return RedirectToAction("List");
        }
    }
}