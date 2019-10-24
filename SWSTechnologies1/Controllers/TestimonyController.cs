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
    public class TestimonyController : Controller
    {
        private readonly SWSTechDBContext _context;

        public TestimonyController(SWSTechDBContext context)
        {
            _context = context;
        }

        // GET: Testimony
        [Authorize]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Testimonials.ToListAsync());
        }

        // GET: Testimony/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testimonyModel = await _context.Testimonials
                .FirstOrDefaultAsync(m => m.Id == id);
            if (testimonyModel == null)
            {
                return NotFound();
            }

            return View(testimonyModel);
        }

        // GET: Testimony/Create
        public IActionResult Testimonials()
        {
            var model = new TestimonyViewModel();
             model.TestimonyModels  = _context.Testimonials.Where(t => t.Publish == true).AsQueryable().ToList();
            return View(model);
        }
        public ViewResult Thanks()
        {
            return View();
        }

        // POST: Testimony/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Testimonials([Bind("Id,Name,Company,Message,DatePublished,Publish")] TestimonyModel testimonyModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(testimonyModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Thanks));
            }
            return View(testimonyModel);
        }

        // GET: Testimony/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testimonyModel = await _context.Testimonials.FindAsync(id);
            if (testimonyModel == null)
            {
                return NotFound();
            }
            return View(testimonyModel);
        }

        // POST: Testimony/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Company,Message,DatePublished,Publish")] TestimonyModel testimonyModel)
        {
            if (id != testimonyModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(testimonyModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TestimonyModelExists(testimonyModel.Id))
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
            return View(testimonyModel);
        }

        // GET: Testimony/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testimonyModel = await _context.Testimonials
                .FirstOrDefaultAsync(m => m.Id == id);
            if (testimonyModel == null)
            {
                return NotFound();
            }

            return View(testimonyModel);
        }

        // POST: Testimony/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var testimonyModel = await _context.Testimonials.FindAsync(id);
            _context.Testimonials.Remove(testimonyModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TestimonyModelExists(int id)
        {
            return _context.Testimonials.Any(e => e.Id == id);
        }
    }
}
