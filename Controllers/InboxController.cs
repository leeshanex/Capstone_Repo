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
    public class InboxController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InboxController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Inbox
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Inboxes.Include(i => i.Customer).Include(i => i.Guide);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Inbox/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inbox = await _context.Inboxes
                .Include(i => i.Customer)
                .Include(i => i.Guide)
                .FirstOrDefaultAsync(m => m.InboxId == id);
            if (inbox == null)
            {
                return NotFound();
            }

            return View(inbox);
        }

        // GET: Inbox/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerId");
            ViewData["GuideId"] = new SelectList(_context.Guides, "GuideId", "GuideId");
            return View();
        }

        // POST: Inbox/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InboxId,MessagesReceived,MessagesSent,GuideId,CustomerId")] Inbox inbox)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inbox);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerId", inbox.CustomerId);
            ViewData["GuideId"] = new SelectList(_context.Guides, "GuideId", "GuideId", inbox.GuideId);
            return View(inbox);
        }

        // GET: Inbox/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inbox = await _context.Inboxes.FindAsync(id);
            if (inbox == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerId", inbox.CustomerId);
            ViewData["GuideId"] = new SelectList(_context.Guides, "GuideId", "GuideId", inbox.GuideId);
            return View(inbox);
        }

        // POST: Inbox/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InboxId,MessagesReceived,MessagesSent,GuideId,CustomerId")] Inbox inbox)
        {
            if (id != inbox.InboxId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inbox);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InboxExists(inbox.InboxId))
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
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerId", inbox.CustomerId);
            ViewData["GuideId"] = new SelectList(_context.Guides, "GuideId", "GuideId", inbox.GuideId);
            return View(inbox);
        }

        // GET: Inbox/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inbox = await _context.Inboxes
                .Include(i => i.Customer)
                .Include(i => i.Guide)
                .FirstOrDefaultAsync(m => m.InboxId == id);
            if (inbox == null)
            {
                return NotFound();
            }

            return View(inbox);
        }

        // POST: Inbox/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inbox = await _context.Inboxes.FindAsync(id);
            _context.Inboxes.Remove(inbox);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InboxExists(int id)
        {
            return _context.Inboxes.Any(e => e.InboxId == id);
        }
    }
}
