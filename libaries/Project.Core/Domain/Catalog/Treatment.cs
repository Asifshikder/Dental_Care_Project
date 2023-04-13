using Project.Core.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Domain.Catalog
{
    public partial class Treatment : BaseEntity
    {
        public Treatment()
        {
            PatientTreatments = new HashSet<PatientTreatment>();
        }
        public string Title { get; set; }=string.Empty;
        public string Decription { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public virtual ICollection<PatientTreatment> PatientTreatments { get; set; }
    }
}
