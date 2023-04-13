using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.Core.Domain.Authentication;
using Project.Core.Domain.Catalog;
using Project.Core.Domain.Common;
using Project.Core.Domain.Payments;
using Project.Core.Domain.Service;
using Project.Core.Domain.Subscriptions;
using Project.Core.Domain.Vendor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public virtual DbSet<Treatment> Treatments { get; set; }
        public virtual DbSet<BloodGroup> BloodGroups { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<PatientPayment> PatientPayments { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<PatientTreatment> PatientTreatments { get; set; }
        public virtual DbSet<SubscriptionPlan> SubscriptionPlans { get; set; }
        public virtual DbSet<VendorSubscription> VendorSubscriptions { get; set; }
        public virtual DbSet<VendorInfo> VendorInfos { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //FixedData.SeedData(builder);
            base.OnModelCreating(builder);
        }
    }
}
