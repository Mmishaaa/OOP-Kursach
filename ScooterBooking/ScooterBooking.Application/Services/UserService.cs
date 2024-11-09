using AutoMapper;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Repositories;
using ScooterBooking.Domain.Interfaces.Services;

namespace ScooterBooking.Application.Services
{
    public class UserService(IGenericRepository<UserEntity> genericRepository, IMapper mapper) :
        GenericService<UserEntity>(genericRepository, mapper), IUserService
    {
    }
}
