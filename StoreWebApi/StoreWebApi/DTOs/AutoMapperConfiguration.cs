using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using StoreWebApi.Models;

namespace StoreWebApi.DTOs
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                //cfg.CreateMap<Customer, CustomerDTO>()
                //   .ForMember(x => x.CustomerOrder, o => o.Ignore())
                //   //.ForMember(x => x.Nombre, o => o.MapFrom(s => s.FirstName))
                //   .ReverseMap();

                //cfg.CreateMap<CustomerOrder, CustomerOrderDTO>()
                //   .ForMember(x => x.OrderDetail, o => o.Ignore())
                //   .ReverseMap();

                //////////cfg.CreateMap<CurrentWeatherDTO, CurrentWeatherDTO>()
                //////////   .ReverseMap();

                //////////cfg.CreateMap<NewsDTO, NewsDTO>()
                //////////   .ReverseMap();

               
            });
        }
    }
}
