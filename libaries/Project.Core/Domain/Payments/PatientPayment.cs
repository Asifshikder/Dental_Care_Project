using Project.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Domain.Payments
{
    public partial class PatientPayment : BaseEntity
    {
        public long PatientId { get; set; }
        public decimal Amount { get; set; }
        public long PaymentTypeId { get; set; }
        public string Reference { get; set; } = string.Empty;
        public virtual PaymentType PaymentType { get; set; }
    }
}
