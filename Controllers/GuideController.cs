using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Capstone_Proj.Data;
using Capstone_Proj.Models;
using System.Security.Claims;

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
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var loggedInGuide = await _context.Guides.Where(c => c.IdentityUserId == userId).SingleOrDefaultAsync();

            return View();
        }

        // GET: Guide/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var loggedInGuide = _context.Guides.Where(c => c.IdentityUserId == userId).SingleOrDefaultAsync();
            if (loggedInGuide == null)
            {
                return NotFound();
            }

            return View(await loggedInGuide);
        }

        // GET: Guide/Create
        public IActionResult Create()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var loggedInGuide = _context.Guides.Where(c => c.IdentityUserId == userId).SingleOrDefault(); 
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View(loggedInGuide);
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
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                guide.IdentityUserId = userId;
                _context.Add(guide);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details");
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

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var loggedInGuide = _context.Guides.Where(c => c.IdentityUserId == userId).SingleOrDefaultAsync();

            if (loggedInGuide == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", loggedInGuide);
            return View(await loggedInGuide);
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
                    var guideInDB = _context.Guides.Single(g => g.GuideId == guide.GuideId);
                    //guideInDB.WaterType = guide.WaterType;
                    //guideInDB.TargetedSpecies = guide.TargetedSpecies;
                    //guideInDB.Title = guide.Title;
                    //guideInDB.Rates = guide.Rates;
                    //guideInDB.DayLength = guide.DayLength;

                    _context.Update(guideInDB);
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
