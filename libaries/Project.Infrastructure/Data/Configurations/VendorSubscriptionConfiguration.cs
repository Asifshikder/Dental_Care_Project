using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Domain.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Data.Configurations
{
    public class VendorSubscriptionConfiguration : IEntityTypeConfiguration<VendorSubscription>
    {
        public void Configure(EntityTypeBuilder<VendorSubscription> builder)
        {
            builder.HasOne(s => s.VendorInfo)
                .WithMany(c => c.VendorSubscriptions)
                .HasForeignKey(s => s.VendorInfoId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(s => s.SubscriptionPlan)
                .WithMany(c => c.VendorSubscriptions)
                .HasForeignKey(s => s.SubscriptionId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
