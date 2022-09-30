using Auto.Ecommerce.Aplication.DTO;
using Auto.Ecommerce.Domain.Entity;
using AutoMapper;

namespace Auto.Ecommerce.Transversal.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDTO>().ReverseMap();


            //CreateMap<Customer, CustomerDTO>().ReverseMap().ForMember(dest => dest.CustomerId, source => source.MapFrom(origin => origin.CustomerId))
            //     .ForMember(dest => dest.CustomerId, source => source.MapFrom(origin => origin.CustomerId))
            //     .ForMember(dest => dest.Address, source => source.MapFrom(origin => origin.Address))
            //     .ForMember(dest => dest.CompanyName, source => source.MapFrom(origin => origin.CompanyName))
            //     .ForMember(dest => dest.City, source => source.MapFrom(origin => origin.City))
            //     .ForMember(dest => dest.ContactName, source => source.MapFrom(origin => origin.ContactName))
            //     .ForMember(dest => dest.ContactTitle, source => source.MapFrom(origin => origin.ContactTitle))
            //     .ForMember(dest => dest.Country, source => source.MapFrom(origin => origin.Country))
            //     .ForMember(dest => dest.Phone, source => source.MapFrom(origin => origin.Phone))
            //     .ForMember(dest => dest.PostalCode, source => source.MapFrom(origin => origin.PostalCode))
            //     .ForMember(dest => dest.Region, source => source.MapFrom(origin => origin.Region));
        }
    }
}