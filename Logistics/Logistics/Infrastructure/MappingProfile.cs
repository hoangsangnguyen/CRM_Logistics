using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Logistics.Entities;
using Logistics.Models;

namespace Logistics.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Commodity, CommodityDto>();
            CreateMap<CommodityDto, Commodity>();

            CreateMap<AirExp, AirExpDto>();
            CreateMap<AirExpDto, AirExpForCreationDto>();
            CreateMap<AirExpForCreationDto, AirExp>()
                .ForMember(dest => dest.opic, opt => opt.Ignore())
                .ForMember(dest => dest.carrier, opt => opt.Ignore())
                ;

            CreateMap<Express, ExpressDto>();
            CreateMap<ExpressForCreationDto, Express>()
                .ForMember(dest => dest.Commodity, opt => opt.Ignore())
                .ForMember(dest => dest.carrier, opt => opt.Ignore())
                .ForMember(dest => dest.opic, opt => opt.Ignore())
                .ForMember(dest => dest.opic, opt => opt.Ignore())
                .ForMember(dest => dest.unit, opt => opt.Ignore())
                ;
            CreateMap<FclExp, FclExpDto>();
            CreateMap<FclExpForCreationDto, FclExp>()
              .ForMember(dest => dest.Commodity, opt => opt.Ignore())
              .ForMember(dest => dest.Agent, opt => opt.Ignore())
              .ForMember(dest => dest.opic, opt => opt.Ignore())
              .ForMember(dest => dest.Commodity, opt => opt.Ignore())
              .ForMember(dest => dest.Freight, opt => opt.Ignore())
              .ForMember(dest => dest.MBLType, opt => opt.Ignore())
              .ForMember(dest => dest.Shipment, opt => opt.Ignore())
              .ForMember(dest => dest.Vessel, opt => opt.Ignore())
              ;

            CreateMap<LclExp, LclExpDto>();
            CreateMap<LclExpForCreation, LclExp>()
              .ForMember(dest => dest.Commodity, opt => opt.Ignore())
              .ForMember(dest => dest.Agent, opt => opt.Ignore())
              .ForMember(dest => dest.opic, opt => opt.Ignore())
              .ForMember(dest => dest.Commodity, opt => opt.Ignore())
              .ForMember(dest => dest.Freight, opt => opt.Ignore())
              .ForMember(dest => dest.MBLType, opt => opt.Ignore())
              .ForMember(dest => dest.Shipment, opt => opt.Ignore())
              .ForMember(dest => dest.Vessel, opt => opt.Ignore())
              .ForMember(dest => dest.unit, opt => opt.Ignore())
              ;

            CreateMap<AirImp, AirImpDto>();
            CreateMap<AirImpForCreationDto, AirImp>()
                .ForMember(dest => dest.Commodity, opt => opt.Ignore())
                .ForMember(dest => dest.opic, opt => opt.Ignore())
                .ForMember(dest => dest.shipment, opt => opt.Ignore())
                .ForMember(dest => dest.unit, opt => opt.Ignore())
                .ForMember(dest => dest.agent, opt => opt.Ignore())
                ;

            CreateMap<Carrier, CarrierDto>();
            CreateMap<CarrierForCreationDto, Carrier>()
              .ForMember(dest => dest.country, opt => opt.Ignore())
              ;

            CreateMap<Contact, ContactDto>();
            CreateMap<ContactForCreationDto, Contact>()
                .ForMember(dest => dest.department, opt => opt.Ignore())
                .ForMember(dest => dest.position, opt => opt.Ignore())
                ;

            CreateMap<Department, DepartmentDto>();
            CreateMap<Mode, ModeDto>();
            CreateMap<Nationality, NationalityDto>();
            CreateMap<Payment, PaymentDto>();

            CreateMap<Port, PortDto>();
            CreateMap<PortForCreationDto, Port>()
               .ForMember(dest => dest.mode, opt => opt.Ignore())
               .ForMember(dest => dest.nationality, opt => opt.Ignore())
               .ForMember(dest => dest.zone, opt => opt.Ignore())
               ;

            CreateMap<Position, PositionDto>();
            CreateMap<Shipment, ShipmentDto>();
            CreateMap<TypeOfBill, TypeOfBillDto>();
            CreateMap<Unit, UnitDto>();
            CreateMap<Zone, ZoneDto>();
            CreateMap<MBLType, MBLTypeDto>();
            CreateMap<Vessel, VesselDto>();
            CreateMap<Freight, FreightDto>();

        }
    }
}
