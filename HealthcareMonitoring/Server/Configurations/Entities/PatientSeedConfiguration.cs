using HealthcareMonitoring.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthcareMonitoring.Server.Configurations.Entities
{
    public class PatientSeedConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasData(
            new Patient
            {
                Id = 1,
                PatientName = "Paterson",
                NRIC = "S1234567A",
                Gender = "Male",
                Address = "Blk 123 Paterville Ave 3 ",
                Email = "Paterson@mail.com",
                ContactNo = 123456789 ,
                DOB = 12-3-1980,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            });
        }
    }
}
