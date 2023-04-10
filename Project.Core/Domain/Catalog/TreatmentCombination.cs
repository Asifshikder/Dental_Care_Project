using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Domain.Catalog
{
    public class TreatmentCombination : BaseEntity
    {
        public TreatmentCombination()
        {
            TreatmentCombinationTreatments = new HashSet<TreatmentCombinationTreatment>();
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual ICollection<TreatmentCombinationTreatment> TreatmentCombinationTreatments { get; set; }

    }
}
