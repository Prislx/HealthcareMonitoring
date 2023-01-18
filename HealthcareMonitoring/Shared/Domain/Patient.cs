using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareMonitoring.Shared.Domain
{
    public class Patient : BaseDomainModel
    {
        public string PatientName { get; set; }
        public string NRIC { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int ContactNo { get; set; }
        public int DOB { get; set; }
    }
}
