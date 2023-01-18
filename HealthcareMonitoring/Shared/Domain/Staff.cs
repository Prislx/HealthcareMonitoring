using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareMonitoring.Shared.Domain
{
    public class Staff : BaseDomainModel

    {
        public string StaffName { get; set; }
        public string Gender { get; set; }
        public int ContactNo { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}
