using Project.Core.Domain.Catalog;
using Project.Core.Domain.Common;
using Project.Core.Domain.Vendor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Domain.Service
{
    public partial class Patient : BaseEntity
    {
        public Patient()
        {
            PatientTreatments = new HashSet<PatientTreatment>();
        }
        public string FullName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Image { get; set; } = string.Empty;
        public long BloodGroupId { get; set; }
        public long VendorInfoId { get; set; }
        public virtual BloodGroup BloodGroup { get; set; }
        public virtual VendorInfo VendorInfo { get; set; }
        public virtual ICollection<PatientTreatment> PatientTreatments { get; set; }
    }
}
