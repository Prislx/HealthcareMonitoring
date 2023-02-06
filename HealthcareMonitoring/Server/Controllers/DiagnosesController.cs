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
    public class DiagnosesController : ControllerBase
    {
        private readonly IUnitOfWork _unitofwork;

        public DiagnosesController(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        // GET: api/Diagnoses
        [HttpGet]
        public async Task<IActionResult> GetDiagnosis()
        {
            var diagnosis = await _unitofwork.Diagnoses.GetAll(includes: q => q.Include(x => x.Appointment).Include(x => x.Prescription));
            return Ok(diagnosis);
        }

        // GET: api/Diagnoses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Diagnosis>> GetDiagnosis(int id)
        {
            var diagnosis = await _unitofwork.Diagnoses.Get(q => q.Id == id);

            if (diagnosis == null)
            {
                return NotFound();
            }

            return Ok(diagnosis);
        }

        // PUT: api/Diagnoses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDiagnosis(int id, Diagnosis diagnosis)
        {
            if (id != diagnosis.Id)
            {
                return BadRequest();
            }

            _unitofwork.Diagnoses.Update(diagnosis);

            try
            {
                await _unitofwork.Save(HttpContext); ;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await DiagnosisExists(id))
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

        // POST: api/Diagnoses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Diagnosis>> PostDiagnosis(Diagnosis diagnosis)
        {
            await _unitofwork.Diagnoses.Insert(diagnosis);
            await _unitofwork.Save(HttpContext);

            return CreatedAtAction("GetDiagnosis", new { id = diagnosis.Id }, diagnosis);
        }

        // DELETE: api/Diagnoses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDiagnosis(int id)
        {
            var diagnosis = await _unitofwork.Patients.Get(q => q.Id == id);
            if (diagnosis == null)
            {
                return NotFound();
            }

            await _unitofwork.Diagnoses.Delete(id);
            await _unitofwork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> DiagnosisExists(int id)
        {
            var diagnosis = await _unitofwork.Diagnoses.Get(q => q.Id == id);
            return diagnosis != null;
        }
    }
}
