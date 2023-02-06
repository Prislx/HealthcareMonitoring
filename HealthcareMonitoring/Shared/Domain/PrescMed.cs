using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareMonitoring.Shared.Domain
{
    public class PrescMed : BaseDomainModel
    {
        public int MedQty { get; set; }
        public int MedicineID { get; set; }
        public virtual Medicine Medicine { get; set; }
        public int PrescriptionID { get; set; }
        public virtual List<Prescription> Prescription { get; set; }
        public string Dosage { get; set; }
    }
}
