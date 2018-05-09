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
    public class ContactsController : GenericController<Contact, ContactDto, ContactForCreationDto>
    {
        private readonly DatabaseContext _context;
        private readonly IContactRepository _contactRepository;

        public ContactsController(IContactRepository contactRepository, DatabaseContext context) : base(contactRepository, context)
        {
            _contactRepository = contactRepository;
            _context = context;
        }

    }
}
