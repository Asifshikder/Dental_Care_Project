using Project.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Domain.Subscriptions
{
    public partial class SubscriptionPlan : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public PricingType PricingPlan { get; set; }
        public string Features { get; set; } = string.Empty;
    }
}
