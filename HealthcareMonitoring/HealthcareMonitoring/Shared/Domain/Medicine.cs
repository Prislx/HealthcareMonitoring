using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareMonitoring.Shared.Domain
{
    public class Medicine : BaseDomainModel, IValidatableObject
    {
        public string MedName { get; set; }
        public string Description { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int Quantity { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (ExpiryDate != null)
            {
                if (ExpiryDate < System.DateTime.Now)
                {
                    yield return new ValidationResult("The medicine has expired and cannot be kept", new[] { "ExpiryDate" });
                }

               

            }
            if (Quantity <= 0)
            {
                yield return new ValidationResult("Please enter a valid quantity", new[] { "Quantity" });
            }



        }

        
            


        
    }
}
