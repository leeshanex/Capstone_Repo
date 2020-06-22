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
    public class FishingSpotsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FishingSpotsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FishingSpots
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Spots.Include(a => a.Guide);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: FishingSpots/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var areaOfExpertise = await _context.Spots
                .Include(a => a.Guide)
                .FirstOrDefaultAsync(m => m.AreaId == id);
            if (areaOfExpertise == null)
            {
                return NotFound();
            }

            return View(areaOfExpertise);
        }

        // GET: FishingSpots/Create
        public IActionResult Create()
        {
            ViewData["GuideId"] = new SelectList(_context.Guides, "GuideId", "GuideId");
            return View();
        }

        // POST: FishingSpots/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AreaId,PinLocation,GuideId")] AreaOfExpertise areaOfExpertise)
        {
            if (ModelState.IsValid)
            {
                _context.Add(areaOfExpertise);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GuideId"] = new SelectList(_context.Guides, "GuideId", "GuideId", areaOfExpertise.GuideId);
            return View(areaOfExpertise);
        }

        // GET: FishingSpots/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var areaOfExpertise = await _context.Spots.FindAsync(id);
            if (areaOfExpertise == null)
            {
                return NotFound();
            }
            ViewData["GuideId"] = new SelectList(_context.Guides, "GuideId", "GuideId", areaOfExpertise.GuideId);
            return View(areaOfExpertise);
        }

        // POST: FishingSpots/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AreaId,PinLocation,GuideId")] AreaOfExpertise areaOfExpertise)
        {
            if (id != areaOfExpertise.AreaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(areaOfExpertise);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AreaOfExpertiseExists(areaOfExpertise.AreaId))
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
            ViewData["GuideId"] = new SelectList(_context.Guides, "GuideId", "GuideId", areaOfExpertise.GuideId);
            return View(areaOfExpertise);
        }

        // GET: FishingSpots/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var areaOfExpertise = await _context.Spots
                .Include(a => a.Guide)
                .FirstOrDefaultAsync(m => m.AreaId == id);
            if (areaOfExpertise == null)
            {
                return NotFound();
            }

            return View(areaOfExpertise);
        }

        // POST: FishingSpots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var areaOfExpertise = await _context.Spots.FindAsync(id);
            _context.Spots.Remove(areaOfExpertise);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AreaOfExpertiseExists(int id)
        {
            return _context.Spots.Any(e => e.AreaId == id);
        }
    }
}
