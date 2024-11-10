using AutoMapper;
using ScooterBooking.Application.ViewModels.BookingViewModel;
using ScooterBooking.Application.ViewModels.InsuranceViewModel;
using ScooterBooking.Application.ViewModels.LocationViewModel;
using ScooterBooking.Application.ViewModels.PaymentViewModel;
using ScooterBooking.Application.ViewModels.PricingViewModel;
using ScooterBooking.Application.ViewModels.ReviewViewModel;
using ScooterBooking.Application.ViewModels.ScooterViewModel;
using ScooterBooking.Application.ViewModels.UserViewModel;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.PaginationModels;

namespace ScooterBooking.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BookingEntity, BookingViewModel>();
            CreateMap<InsuranceEntity, InsuranceViewModel>();
            CreateMap<LocationEntity, LocationViewModel>();
            CreateMap<PaymentEntity, PaymentViewModel>();
            CreateMap<PricingEntity, PricingViewModel>();
            CreateMap<ReviewEntity, ReviewViewModel>();
            CreateMap<ScooterEntity, ScooterViewModel>();
            CreateMap<UserEntity, UserViewModel>();
            CreateMap(typeof(PagedResult<>), typeof(PagedResult<>));
        }
    }
}
