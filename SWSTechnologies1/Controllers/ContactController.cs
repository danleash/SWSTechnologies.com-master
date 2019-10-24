using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SWSTechnologies1.Models;

namespace SWSTechnologies1.Controllers
{
    public class ContactController : Controller
    {
        private readonly SWSTechDBContext _context;
        public ContactController(SWSTechDBContext context)
        {
            _context = context;
        }

        // GET: Contact
        [Authorize]
        public async Task<IActionResult> Index()
        {
            return View(await _context.ClientContactInfo.ToListAsync());
        }

        // GET: Contact/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactClientModel = await _context.ClientContactInfo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactClientModel == null)
            {
                return NotFound();
            }

            return View(contactClientModel);
        }

        // GET: Contact/Create
        public IActionResult Create()
        {
            return View();
        }
        public ViewResult Thanks()
        {
            return View("Thanks");
        }

        // POST: Contact/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,PhoneNumber,EmailAddress,Message")] ContactClientModel contactClientModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contactClientModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Thanks));
            }
            return View(contactClientModel);
        }

        // GET: Contact/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactClientModel = await _context.ClientContactInfo.FindAsync(id);
            if (contactClientModel == null)
            {
                return NotFound();
            }
            return View(contactClientModel);
        }

        // POST: Contact/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,PhoneNumber,EmailAddress,Message,BeenHelped,EntryDate,ServiceRequested,Comments")] ContactClientModel contactClientModel)
        {
            if (id != contactClientModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contactClientModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactClientModelExists(contactClientModel.Id))
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
            return View(contactClientModel);
        }

        // GET: Contact/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactClientModel = await _context.ClientContactInfo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactClientModel == null)
            {
                return NotFound();
            }

            return View(contactClientModel);
        }

        // POST: Contact/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contactClientModel = await _context.ClientContactInfo.FindAsync(id);
            _context.ClientContactInfo.Remove(contactClientModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactClientModelExists(int id)
        {
            return _context.ClientContactInfo.Any(e => e.Id == id);
        }
    }
}
