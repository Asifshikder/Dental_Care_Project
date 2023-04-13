using Project.Core.Domain.Service;
using Project.Core.Domain.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Domain.Vendor
{
    public partial class VendorInfo : BaseEntity
    {
        public VendorInfo()
        {
            VendorSubscriptions = new HashSet<VendorSubscription>();
            Patients = new HashSet<Patient>();
        }
        public string Title { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string SecondaryPhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Logo { get; set; } = string.Empty;
        public string UserId { get; set; }
        public virtual ICollection<VendorSubscription> VendorSubscriptions { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
