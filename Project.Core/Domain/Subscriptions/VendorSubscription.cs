using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Domain.Subscriptions
{
    public partial class VendorSubscription : BaseEntity
    {
        public long VendorId { get; set; }
        public long SubscribtionId { get; set; }
    }
}
