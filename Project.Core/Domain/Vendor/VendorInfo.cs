using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Domain.Vendor
{
    public partial class VendorInfo : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string SecondaryPhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }
}
