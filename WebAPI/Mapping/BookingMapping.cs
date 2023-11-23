using AutoMapper;
using EntityLayer.Dtos.BookingDtos;
using EntityLayer.Entities;

namespace WebAPI.Mapping
{
    public class BookingMapping : Profile
    {
        public BookingMapping()
        {
            CreateMap<Booking, BookingDto>().ReverseMap();
            CreateMap<Booking, CreateBookingDto>().ReverseMap();
            CreateMap<Booking, UpdateBookingDto>().ReverseMap();
            CreateMap<Booking, GetBookingDto>().ReverseMap();
        }
    }
}
