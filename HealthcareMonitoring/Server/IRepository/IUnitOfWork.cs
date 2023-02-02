using HealthcareMonitoring.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthcareMonitoring.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Appointment> Appointments { get; }
        IGenericRepository<Diagnosis> Diagnoses { get; }
        IGenericRepository<Medicine> Medicines { get; }
        IGenericRepository<Patient> Patients { get; }
        IGenericRepository<PrescMed> PrescMeds { get; }
        IGenericRepository<Prescription> Prescriptions { get; }
        IGenericRepository<Staff> Staffs { get; }

    }
}