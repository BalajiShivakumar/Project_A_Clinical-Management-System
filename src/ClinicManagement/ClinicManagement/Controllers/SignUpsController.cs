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
    public class SignUpsController : Controller
    {
        private readonly ClinicContext _context;

        public SignUpsController(ClinicContext context)
        {
            _context = context;
        }


        

        // GET: SignUps
        public async Task<IActionResult> Index()
        {
            return View(await _context.SignUpTable.ToListAsync());
        }


        // GET: SignUps/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var signUp = await _context.SignUpTable
                .FirstOrDefaultAsync(m => m.Username == id);
            if (signUp == null)
            {
                return NotFound();
            }

            return View(signUp);
        }



        // GET: SignUps/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SignUps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Username,Sex,Age,StaffEmail,Password")] SignUp signUp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(signUp);
                await _context.SaveChangesAsync();
                return RedirectToAction("SignIn","SignIns");
            }
            return View(signUp);
        }



        // GET: SignUps/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var signUp = await _context.SignUpTable.FindAsync(id);
            if (signUp == null)
            {
                return NotFound();
            }
            return View(signUp);
        }



        // POST: SignUps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Username,Sex,Age,StaffEmail,Password")] SignUp signUp)
        {
            if (id != signUp.Username)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(signUp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SignUpExists(signUp.Username))
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
            return View(signUp);
        }



        // GET: SignUps/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var signUp = await _context.SignUpTable
                .FirstOrDefaultAsync(m => m.Username == id);
            if (signUp == null)
            {
                return NotFound();
            }

            return View(signUp);
        }



        // POST: SignUps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var signUp = await _context.SignUpTable.FindAsync(id);
            _context.SignUpTable.Remove(signUp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SignUpExists(string id)
        {
            return _context.SignUpTable.Any(e => e.Username == id);
        }
    }
}
