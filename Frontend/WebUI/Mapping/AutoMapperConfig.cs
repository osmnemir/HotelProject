using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using WebUI.DTOs.AboutDto;
using WebUI.DTOs.AppUserDto;
using WebUI.DTOs.BookingDto;
using WebUI.DTOs.ContectDto;
using WebUI.DTOs.GuestDto;
using WebUI.DTOs.LoginDto;
using WebUI.DTOs.RegisterDto;
using WebUI.DTOs.ServiceDto;
using WebUI.DTOs.StaffDto;
using WebUI.DTOs.SubscribeDto;
using WebUI.DTOs.TestimonialDto;

namespace WebUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig() //DTOs a yazdığımızları burda tanımlıyoruz.
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<CreateNewUserDto,AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();

            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();

            CreateMap<ResultTestimonialDto , Testimonial>().ReverseMap();

            CreateMap<ResultStaffDto, Staff>().ReverseMap();

            CreateMap<ResultSubscribeDto , Subscribe>().ReverseMap();

            CreateMap<CreateBookingDto , Booking>().ReverseMap();
            CreateMap<ApprovedReservationDto, Booking>().ReverseMap();

            CreateMap<CreateContactDto, Contact>().ReverseMap();

            CreateMap<CreateGuestDto, Guest>().ReverseMap();
            CreateMap<UpdateGuestDto, Guest>().ReverseMap();

            CreateMap<ResultAppUserDto, AppUser>().ReverseMap();





        }

    }
}
