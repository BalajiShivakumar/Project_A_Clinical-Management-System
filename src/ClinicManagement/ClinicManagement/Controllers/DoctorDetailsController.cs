using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClinicManagement.Models;

namespace ClinicManagement.Controllers
{
    public class DoctorDetailsController : Controller
    {
        private readonly ClinicContext _context;

        public DoctorDetailsController(ClinicContext context)
        {
            _context = context;
        }

        // GET: DoctorDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.DoctorTable.ToListAsync());
        }

        // GET: DoctorDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctorDetails = await _context.DoctorTable
                .FirstOrDefaultAsync(m => m.DoctorID == id);
            if (doctorDetails == null)
            {
                return NotFound();
            }

            return View(doctorDetails);
        }

        // GET: DoctorDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DoctorDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DoctorID,FirstName,LastName,Sex,Age,BirthDate,SpecializationRequired,Experiance,DocEmail,ContactNo")] DoctorDetails doctorDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doctorDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(doctorDetails);
        }

        // GET: DoctorDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctorDetails = await _context.DoctorTable.FindAsync(id);
            if (doctorDetails == null)
            {
                return NotFound();
            }
            return View(doctorDetails);
        }

        // POST: DoctorDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DoctorID,FirstName,LastName,Sex,Age,BirthDate,SpecializationRequired,Experiance,DocEmail,ContactNo")] DoctorDetails doctorDetails)
        {
            if (id != doctorDetails.DoctorID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doctorDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoctorDetailsExists(doctorDetails.DoctorID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(doctorDetails);
        }

        // GET: DoctorDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctorDetails = await _context.DoctorTable
                .FirstOrDefaultAsync(m => m.DoctorID == id);
            if (doctorDetails == null)
            {
                return NotFound();
            }

            return View(doctorDetails);
        }

        // POST: DoctorDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doctorDetails = await _context.DoctorTable.FindAsync(id);
            _context.DoctorTable.Remove(doctorDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoctorDetailsExists(int id)
        {
            return _context.DoctorTable.Any(e => e.DoctorID == id);
        }
    }
}
