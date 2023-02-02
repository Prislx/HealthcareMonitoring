using HealthcareMonitoring.Server.Data;
using HealthcareMonitoring.Server.IRepository;
using HealthcareMonitoring.Shared.Domain;
using HealthcareMonitoring.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HealthcareMonitoring.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Appointment> _Appointment;
        private IGenericRepository<Diagnosis> _Diagnoses;
        private IGenericRepository<Medicine> _Medicine;
        private IGenericRepository<Patient> _Patient;
        private IGenericRepository<PrescMed> _PrescMed;
        private IGenericRepository<Prescription> _Prescription;
        private IGenericRepository<Staff> _Staff;

        private UserManager<ApplicationUser> _userManager;
       

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<Appointment> Appointments
            => _Appointment ??= new GenericRepository<Appointment>(_context);
        public IGenericRepository<Diagnosis> Diagnoses
            => _Diagnoses ??= new GenericRepository<Diagnosis>(_context);
        public IGenericRepository<Medicine> Medicines
            => _Medicine ??= new GenericRepository<Medicine>(_context);
        public IGenericRepository<Patient> Patients
            => _Patient ??= new GenericRepository<Patient>(_context);
        public IGenericRepository<PrescMed> PrescMeds
            => _PrescMed ??= new GenericRepository<PrescMed>(_context);
        public IGenericRepository<Prescription> Prescriptions
            => _Prescription ??= new GenericRepository<Prescription>(_context);
        public IGenericRepository<Staff> Staffs
            => _Staff ??= new GenericRepository<Staff>(_context);


        public IGenericRepository<Appointment> Appointment => throw new NotImplementedException();

        public IGenericRepository<Diagnosis> Diagnosis => throw new NotImplementedException();

        public IGenericRepository<Medicine> Medicine => throw new NotImplementedException();

        public IGenericRepository<Patient> Patient => throw new NotImplementedException();

        public IGenericRepository<PrescMed> PrescMed => throw new NotImplementedException();

        public IGenericRepository<Prescription> Prescription => throw new NotImplementedException();

        public IGenericRepository<Staff> Staff => throw new NotImplementedException();

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}