using HealthcareMonitoring.Server.Configurations.Entities;
using HealthcareMonitoring.Server.Models;
using HealthcareMonitoring.Shared.Domain;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthcareMonitoring.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Diagnosis> Diagnoses { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<PrescMed> PrescMeds { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new StaffSeedConfiguration());
            builder.ApplyConfiguration(new AppointmentSeedConfiguration());
            builder.ApplyConfiguration(new DiagnosisSeedConfiguration());
            builder.ApplyConfiguration(new MedicineSeedConfiguration());
            builder.ApplyConfiguration(new PatientSeedConfiguration());
            builder.ApplyConfiguration(new PrescMedSeedConfiguration());
            builder.ApplyConfiguration(new PrescriptionSeedConfiguration());
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
        }
    }
}
