using AutoMapper;
using EntityLayer.Dtos.CategoryDtos;
using EntityLayer.Dtos.ContactDtos;
using EntityLayer.Entities;

namespace WebAPI.Mapping
{
    public class ContactMapping : Profile
    {
        public ContactMapping()
        {
            CreateMap<Contact, ContactDto>().ReverseMap();
            CreateMap<Contact, CreateContactDto>().ReverseMap();
            CreateMap<Contact, UpdateContactDto>().ReverseMap();
            CreateMap<Contact, GetContactDto>().ReverseMap();
        }
    }
}
