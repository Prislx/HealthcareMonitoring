using HealthcareMonitoring.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthcareMonitoring.Server.Configurations.Entities
{
    public class AppointmentSeedConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Appointment> builder)
        {
            builder.HasData(
            new Appointment
            {
                Id= 1,
                Description = "" ,
                AppdateTime =  ,
                PatientId = ,
                StaffId =  ,
            }
            );
        }
    }
}
