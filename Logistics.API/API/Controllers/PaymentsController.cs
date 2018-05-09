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
    public class PaymentsController : GenericController<Payment, PaymentDto, PaymentDto>
    {
        private readonly DatabaseContext _context;
        private readonly IPaymentRepository _paymentRepository;

        public PaymentsController(IPaymentRepository paymentRepository, DatabaseContext context) : base(paymentRepository, context)
        {
            _paymentRepository = paymentRepository;
            _context = context;
        }

    }
}
