using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;
using ScooterBooking.Domain.Interfaces.Interceptors;

namespace ScooterBooking.Infrastructure.Interceptors
{
    public sealed class UpdateAuditableInterceptor : SaveChangesInterceptor
    {
        public override ValueTask<InterceptionResult<int>> SavingChangesAsync(
            DbContextEventData eventData,
            InterceptionResult<int> result,
            CancellationToken cancellationToken = default)
        {
            if (eventData.Context is not null)
            {
                UpdateAuditableEntities(eventData.Context);
            }

            return base.SavingChangesAsync(eventData, result, cancellationToken);
        }

        private static void UpdateAuditableEntities(DbContext context)
        {
            var utcNow = DateTime.Now;
            var entities = context.ChangeTracker.Entries<IAuditable>().ToList();

            foreach (var entry in entities)
            {
                if (entry.State == EntityState.Added)
                {
                    SetCurrentPropertyValue(
                        entry, nameof(IAuditable.CreatedAt), utcNow);
                }
            }

            static void SetCurrentPropertyValue(
                EntityEntry entry,
                string propertyName,
                DateTime utcNow) =>
                entry.Property(propertyName).CurrentValue = utcNow;
        }
    }
}
