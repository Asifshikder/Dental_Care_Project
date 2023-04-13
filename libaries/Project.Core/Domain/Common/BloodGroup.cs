using Project.Core.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Domain.Common
{
    public partial class BloodGroup : BaseEntity
    {
        public BloodGroup()
        {
            Patients = new HashSet<Patient>();
        }
        public string Name { get; set; } = string.Empty;
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
