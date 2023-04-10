using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Domain.Catalog
{
    public class TreatmentCombinationTreatment : BaseEntity
    {
        public long TreatmentId { get; set; }
        public long TreatmentCombinationId { get; set; }
        public virtual Treatment Treatment { get; set; }
        public virtual TreatmentCombination TreatmentCombination { get; set; }
    }
}
