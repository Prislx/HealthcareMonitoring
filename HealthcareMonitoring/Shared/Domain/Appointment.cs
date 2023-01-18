using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareMonitoring.Shared.Domain
{
    public class Appointment : BaseDomainModel
    {
        public string Description { get; set; }
        public DateTime AppdateTime { get; set; }
        public int PatientId { get; set; }
        public int StaffId { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Staff Staff { get; set; }
    }
}