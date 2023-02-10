using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareMonitoring.Shared.Domain
{
    public class Prescription : BaseDomainModel, IValidatableObject
    {
        public string Description { get; set; }
        public DateTime? DateTime { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (DateTime != null)
            {
                if (DateTime < System.DateTime.Now)
                {
                    yield return new ValidationResult("Prescription date cannot be after today", new[] { "DateTime" });
                }

            }
        }
    }
}
