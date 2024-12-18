﻿using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Repositories;

namespace ScooterBooking.Infrastructure.Repositories
{
    public class ScooterRepository(ApplicationDbContext context) : GenericRepository<ScooterEntity>(context), IScooterRepository
    {
    }
}
