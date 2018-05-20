using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logistics.Entities;
using Logistics.Models;

namespace Logistics.Services
{
    public class TypeOfBillsRepository : GenericRepository<TypeOfBill, TypeOfBillDto, TypeOfBillDto>, ITypeOfBillsRepository
    {
        private DatabaseContext _context;

        public TypeOfBillsRepository(DatabaseContext context) : base(context)
        {
            _context = context;
        }
    }
}
