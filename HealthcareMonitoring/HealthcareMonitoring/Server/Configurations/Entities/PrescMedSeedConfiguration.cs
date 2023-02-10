using HealthcareMonitoring.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthcareMonitoring.Server.Configurations.Entities
{
    public class PrescMedSeedConfiguration : IEntityTypeConfiguration<PrescMed>
    {
        public void Configure(EntityTypeBuilder<PrescMed> builder)
        {
            builder.HasData(
                new PrescMed
                {
                    Id = 2,
                    MedQty = 6,
                    MedicineID = 2,
                    PrescriptionID = 2,
                    Dosage = "Take 2 a day after meals.",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
