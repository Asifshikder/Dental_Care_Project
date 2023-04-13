using Project.Core.Domain.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Domain.Common
{
    public partial class PaymentType : BaseEntity
    {
        public PaymentType()
        {
            PatientPayments = new HashSet<PatientPayment>();
        }
        public string Name { get; set; } = string.Empty;
        public virtual ICollection<PatientPayment> PatientPayments { get; set; }
    }
}
