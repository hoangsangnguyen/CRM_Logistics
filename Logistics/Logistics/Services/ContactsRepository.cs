using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logistics.Entities;
using Logistics.Models;

namespace Logistics.Services
{
    public class ContactsRepository : GenericRepository<Contact, ContactDto, ContactForCreationDto>, IContactsRepository
    {
        private DatabaseContext _context;

        public ContactsRepository(DatabaseContext context) : base(context)
        {
            _context = context;
        }
    }
}
