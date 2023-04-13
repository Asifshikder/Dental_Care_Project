using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Data.Configurations
{
    public class PatientTreatmentConfiguration : IEntityTypeConfiguration<PatientTreatment>
    {
        public void Configure(EntityTypeBuilder<PatientTreatment> builder)
        {
            builder.HasOne(s => s.Patient)
                .WithMany(c => c.PatientTreatments)
                .HasForeignKey(s => s.PatientId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(s => s.Treatment)
                .WithMany(c => c.PatientTreatments)
                .HasForeignKey(s => s.TreatmentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
