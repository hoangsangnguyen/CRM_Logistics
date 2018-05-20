using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logistics.Entities;
using Logistics.Models;

namespace Logistics.Services
{
    public class PaymentsRepository : GenericRepository<Payment, PaymentDto, PaymentDto>, IPaymentsRepository
    {
        private DatabaseContext _context;

        public PaymentsRepository(DatabaseContext context) : base(context)
        {
            _context = context;
        }
    }
}
