using Project.Core.Domain.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Domain.Service
{
    public partial class PatientTreatment : BaseEntity
    {
        public long PatientId { get; set; }
        public long TreatmentId { get; set; }
        public int ToothQuantity { get; set; }
        public decimal Price { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Treatment Treatment { get; set; }
    }
}
