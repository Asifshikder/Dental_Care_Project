using Microsoft.EntityFrameworkCore;
using Project.Core.Domain.Catalog;
using Project.Core.Domain.Common;
using Project.Core.Domain.Payments;
using Project.Core.Domain.Service;
using Project.Core.Domain.Subscriptions;
using Project.Core.Domain.Vendor;

namespace Project.Infrastructure.Data
{
    public interface IApplicationDbContext
    {
        DbSet<BloodGroup> BloodGroups { get; set; }
        DbSet<PatientPayment> PatientPayments { get; set; }
        DbSet<Patient> Patients { get; set; }
        DbSet<PatientTreatment> PatientTreatments { get; set; }
        DbSet<PaymentType> PaymentTypes { get; set; }
        DbSet<SubscriptionPlan> SubscriptionPlans { get; set; }
        DbSet<Treatment> Treatments { get; set; }
        DbSet<VendorInfo> VendorInfos { get; set; }
        DbSet<VendorSubscription> VendorSubscriptions { get; set; }
        Task<int> SaveChangesAsync();

    }
}