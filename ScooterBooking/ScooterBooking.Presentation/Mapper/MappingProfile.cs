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

namespace ScooterBooking.Presentation.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap(typeof(PagedResult<>), typeof(PagedResult<>));

            CreateMap<CreateBookingViewModel, BookingEntity>();
            CreateMap<UpdateBookingViewModel, BookingEntity>();
            CreateMap<BookingEntity, BookingViewModel>();
            CreateMap<BookingEntity, ShortBookingViewModel>();

            CreateMap<CreateInsuranceViewModel, InsuranceEntity>();
            CreateMap<InsuranceEntity, InsuranceViewModel>();
            CreateMap<UpdateInsuranceViewModel, InsuranceEntity>();
            CreateMap<InsuranceEntity, ShortInsuranceViewModel>();

            CreateMap<CreateLocationViewModel, LocationEntity>();
            CreateMap<LocationEntity, LocationViewModel>();
            CreateMap<UpdateLocationViewModel, LocationEntity>();
            CreateMap<LocationEntity, ShortLocationViewModel>();

            CreateMap<PaymentEntity, PaymentViewModel>();
            CreateMap<CreatePaymentViewModel, PaymentEntity>();
            CreateMap<UpdatePaymentViewModel, PaymentEntity>();
            CreateMap<PaymentEntity, ShortPaymentViewModel>();

            CreateMap<PricingEntity, PricingViewModel>();
            CreateMap<CreatePricingViewModel, PricingEntity>();
            CreateMap<UpdatePricingViewModel, PricingEntity>();
            CreateMap<PricingEntity, ShortPricingViewModel>();

            CreateMap<ReviewEntity, ReviewViewModel>();
            CreateMap<CreateReviewViewModel, ReviewEntity>();
            CreateMap<UpdateReviewViewModel, ReviewEntity>();
            CreateMap<ReviewEntity, ShortReviewViewModel>();

            //CreateMap<ScooterEntity, ScooterViewModel>().ReverseMap();
            CreateMap<ScooterEntity, ScooterViewModel>().ReverseMap();
            CreateMap<CreateScooterViewModel, ScooterEntity>();
            CreateMap<UpdateScooterViewModel, ScooterEntity>();
            CreateMap<ScooterEntity, ShortScooterViewModel>();

            CreateMap<UserEntity, UserViewModel>();
            CreateMap<CreateUserViewModel, UserEntity>();
            CreateMap<UpdateUserViewModel, UserEntity>();
            CreateMap<UserEntity, ShortUserViewModel>();
        }
    }
}
