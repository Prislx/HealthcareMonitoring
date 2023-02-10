using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HealthcareMonitoring.Shared.Domain
{
    public class Appointment : BaseDomainModel, IValidatableObject
    {
        public string Description { get; set; }
        public DateTime? AppdateTime { get; set; }
        public int? PatientId { get; set; }
        public int? StaffId { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Staff Staff { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (AppdateTime != null)
            {
                if (AppdateTime <= DateTime.Now)
                {
                    yield return new ValidationResult("Appointment date cannot be before today", new[] { "AppdateTime" });
                }
            }
        }
    }
}