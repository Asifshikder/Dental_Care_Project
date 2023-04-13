using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Domain.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Data.Configurations
{
    public class PatientPaymentConfiguration : IEntityTypeConfiguration<PatientPayment>
    {
        public void Configure(EntityTypeBuilder<PatientPayment> builder)
        {
            builder.HasOne(s => s.PaymentType)
                .WithMany(c => c.PatientPayments)
                .HasForeignKey(s => s.PaymentTypeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
