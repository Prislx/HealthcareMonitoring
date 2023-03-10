using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HealthcareMonitoring.Server.Data;
using HealthcareMonitoring.Shared.Domain;
using HealthcareMonitoring.Server.IRepository;

namespace HealthcareMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly IUnitOfWork _unitofwork;

        public AppointmentsController(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        // GET: api/Appointments
        [HttpGet]
        public async Task<IActionResult> GetAppointments()
        {
            
            var appointments = await _unitofwork.Appointments.GetAll(includes: q => q.Include(x =>x.Patient).Include(x => x.Staff));
            return Ok(appointments);
        }

        // GET: api/Appointments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Appointment>> GetAppointments(int id)
        {
            var appointment = await _unitofwork.Appointments.Get(q => q.Id == id);

            if (appointment == null)
            {
                return NotFound();
            }
            return Ok(appointment);
        }

        // PUT: api/Appointments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppointment(int id, Appointment appointment)
        {
            if (id != appointment.Id)
            {
                return BadRequest();
            }

            _unitofwork.Appointments.Update(appointment);

            try
            {
                await _unitofwork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await AppointmentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }


        // POST: api/Appointments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Appointment>> PostAppointment(Appointment appointment)
        {
            await _unitofwork.Appointments.Insert(appointment);
            await _unitofwork.Save(HttpContext);

            return CreatedAtAction("GetAppointment", new { id = appointment.Id }, appointment);
        }

        // DELETE: api/Appointments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppointment(int id)
        {
            var appointment = await _unitofwork.Appointments.Get(q => q.Id == id);
            if (appointment == null)
            {
                return NotFound();
            }

            await _unitofwork.Appointments.Delete(id);
            await _unitofwork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> AppointmentExists(int id)
        {
            var appointment = await _unitofwork.Appointments.Get(q => q.Id == id);
            return appointment != null;
        }
    }
}
