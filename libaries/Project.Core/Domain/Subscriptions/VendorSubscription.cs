using Project.Core.Domain.Vendor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Domain.Subscriptions
{
    public partial class VendorSubscription : BaseEntity
    {
        public long VendorInfoId { get; set; }
        public long SubscriptionId { get; set; }
        public DateTime ExpiredAt { get; set; }
        public virtual VendorInfo VendorInfo { get; set; }
        public virtual SubscriptionPlan SubscriptionPlan { get; set; }
    }
}
