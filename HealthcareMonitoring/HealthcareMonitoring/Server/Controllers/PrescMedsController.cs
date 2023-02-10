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
    public class PrescMedsController : ControllerBase
    {
        private readonly IUnitOfWork _unitofwork;

        public PrescMedsController(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork; 
        }

        // GET: api/PrescMeds
        [HttpGet]

        public async Task<IActionResult> GetPrescMed()
        {
            
            var PrescMed = await _unitofwork.PrescMeds.GetAll(includes: q => q.Include(x => x.Medicine).Include(x => x.Prescription));
            return Ok(PrescMed);
        }
      

        // GET: api/PrescMeds/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PrescMed>> GetPrescMed(int id)
        {
            var prescMed = await _unitofwork.PrescMeds.Get(q => q.Id == id);

            if (prescMed == null)
            {
                return NotFound();
            }

            return Ok(prescMed);
        }

        // PUT: api/PrescMeds/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrescMed(int id, PrescMed PrescMed)
        {
            if (id != PrescMed.Id)
            {
                return BadRequest();
            }

            _unitofwork.PrescMeds.Update(PrescMed);

            try
            {
                await _unitofwork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await PrescMedExists(id))
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

        // POST: api/PrescMeds
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PrescMed>> PostPrescMed(PrescMed PrescMed)
        {
            await _unitofwork.PrescMeds.Insert(PrescMed);
            await _unitofwork.Save(HttpContext);

            return CreatedAtAction("GetPrescMed", new { id = PrescMed.Id }, PrescMed);
        }

        // DELETE: api/PrescMeds/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrescMed(int id)
        {
            var PrescMed = await _unitofwork.PrescMeds.Get(q => q.Id == id);
            if (PrescMed == null)
            {
                return NotFound();
            }

            await _unitofwork.PrescMeds.Delete(id);
            await _unitofwork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> PrescMedExists(int id)
        {
            var make = await _unitofwork.PrescMeds.Get(q => q.Id == id);
            return make != null;
        }
    }
}
