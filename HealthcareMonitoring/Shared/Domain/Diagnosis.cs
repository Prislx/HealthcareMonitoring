using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareMonitoring.Shared.Domain
{
    public class Diagnosis : BaseDomainModel
    {
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        public int AppointmentId { get; set; }
        public int PrescriptionId { get; set; }
        public virtual List<Prescription> Prescription { get; set; }
        public virtual List<Appointment>  Appointment { get; set; }
    }

    
}
