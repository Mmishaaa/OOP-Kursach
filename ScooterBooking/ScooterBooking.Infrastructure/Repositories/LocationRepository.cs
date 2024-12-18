﻿using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Repositories;

namespace ScooterBooking.Infrastructure.Repositories
{
    public class LocationRepository(ApplicationDbContext context) : GenericRepository<LocationEntity>(context), ILocationRepository
    {
    }
}
