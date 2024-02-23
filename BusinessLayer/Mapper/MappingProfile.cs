using AutoMapper;
using BusinessLayer.Dtos;
using DataAccessLayer.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateVehicleDTO, Vehicle>().ReverseMap();
            CreateMap<UpdateVehicleDTO, Vehicle>().ReverseMap();
            CreateMap<CreateBidDTO, Bid>().ReverseMap();
            CreateMap<UpdateBidDTO, Bid>().ReverseMap();
            CreateMap<CreatePaymentHistoryDTO, PaymentHistory>().ReverseMap();
        }
    }
}
