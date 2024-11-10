using AutoMapper;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Repositories;
using ScooterBooking.Domain.Interfaces.Services;

namespace ScooterBooking.Application.Services
{
    public class UserService(IUserRepository userRepository, IMapper mapper) :
        GenericService<UserEntity>(userRepository, mapper), IUserService
    {
    }
}
