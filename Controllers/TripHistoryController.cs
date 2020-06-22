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
    public class TripHistoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TripHistoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TripHistory
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.FishingTrips.Include(f => f.Customer).Include(f => f.Guide);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: TripHistory/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fishingTrip = await _context.FishingTrips
                .Include(f => f.Customer)
                .Include(f => f.Guide)
                .FirstOrDefaultAsync(m => m.TripId == id);
            if (fishingTrip == null)
            {
                return NotFound();
            }

            return View(fishingTrip);
        }

        // GET: TripHistory/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerId");
            ViewData["GuideId"] = new SelectList(_context.Guides, "GuideId", "GuideId");
            return View();
        }

        // POST: TripHistory/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TripId,TripPhoto,TripHistory,GuideId,CustomerId")] FishingTrip fishingTrip)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fishingTrip);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerId", fishingTrip.CustomerId);
            ViewData["GuideId"] = new SelectList(_context.Guides, "GuideId", "GuideId", fishingTrip.GuideId);
            return View(fishingTrip);
        }

        // GET: TripHistory/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fishingTrip = await _context.FishingTrips.FindAsync(id);
            if (fishingTrip == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerId", fishingTrip.CustomerId);
            ViewData["GuideId"] = new SelectList(_context.Guides, "GuideId", "GuideId", fishingTrip.GuideId);
            return View(fishingTrip);
        }

        // POST: TripHistory/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TripId,TripPhoto,TripHistory,GuideId,CustomerId")] FishingTrip fishingTrip)
        {
            if (id != fishingTrip.TripId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fishingTrip);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FishingTripExists(fishingTrip.TripId))
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
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerId", fishingTrip.CustomerId);
            ViewData["GuideId"] = new SelectList(_context.Guides, "GuideId", "GuideId", fishingTrip.GuideId);
            return View(fishingTrip);
        }

        // GET: TripHistory/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fishingTrip = await _context.FishingTrips
                .Include(f => f.Customer)
                .Include(f => f.Guide)
                .FirstOrDefaultAsync(m => m.TripId == id);
            if (fishingTrip == null)
            {
                return NotFound();
            }

            return View(fishingTrip);
        }

        // POST: TripHistory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fishingTrip = await _context.FishingTrips.FindAsync(id);
            _context.FishingTrips.Remove(fishingTrip);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FishingTripExists(int id)
        {
            return _context.FishingTrips.Any(e => e.TripId == id);
        }
    }
}
