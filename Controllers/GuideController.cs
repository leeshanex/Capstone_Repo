using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Capstone_Proj.Data;
using Capstone_Proj.Models;

namespace Capstone_Proj.Controllers
{
    public class GuideController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GuideController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Guide
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Guides.Include(g => g.IdentityUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Guide/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guide = await _context.Guides
                .Include(g => g.IdentityUser)
                .FirstOrDefaultAsync(m => m.GuideId == id);
            if (guide == null)
            {
                return NotFound();
            }

            return View(guide);
        }

        // GET: Guide/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Guide/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,FirstName,LastName,IdentityUserId")] Guide guide)
        {
            if (ModelState.IsValid)
            {
                _context.Add(guide);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", guide.IdentityUserId);
            return View(guide);
        }

        // GET: Guide/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guide = await _context.Guides.FindAsync(id);
            if (guide == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", guide.IdentityUserId);
            return View(guide);
        }

        // POST: Guide/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,FirstName,LastName,IdentityUserId")] Guide guide)
        {
            if (id != guide.GuideId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(guide);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GuideExists(guide.GuideId))
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
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", guide.IdentityUserId);
            return View(guide);
        }

        // GET: Guide/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guide = await _context.Guides
                .Include(g => g.IdentityUser)
                .FirstOrDefaultAsync(m => m.GuideId == id);
            if (guide == null)
            {
                return NotFound();
            }

            return View(guide);
        }

        // POST: Guide/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var guide = await _context.Guides.FindAsync(id);
            _context.Guides.Remove(guide);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GuideExists(int id)
        {
            return _context.Guides.Any(e => e.GuideId == id);
        }
    }
}
