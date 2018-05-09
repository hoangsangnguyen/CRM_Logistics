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
    public class ShipmentsController : GenericController<Shipment, ShipmentDto, ShipmentDto>
    {
        private readonly DatabaseContext _context;
        private readonly IShipmentRepository _shipmentRepository;

        public ShipmentsController(IShipmentRepository shipmentRepository, DatabaseContext context) : base(shipmentRepository, context)
        {
            _shipmentRepository = shipmentRepository;
            _context = context;
        }

    }
}
