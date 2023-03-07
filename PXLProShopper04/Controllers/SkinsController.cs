using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PXLProShopper04.Data;
using PXLProShopper04.Models;

namespace PXLProShopper04.Controllers
{    
    public class SkinsController : Controller
    {
        private readonly ShopperDbContext _context;

        public SkinsController(ShopperDbContext context)
        {
            _context = context;
        }

        // GET: Skins
        public async Task<IActionResult> Index()
        {
              return View(await _context.Skins.ToListAsync());
        }

        // GET: Skins/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Skins == null)
            {
                return NotFound();
            }

            var skins = await _context.Skins
                .FirstOrDefaultAsync(m => m.SkinId == id);
            if (skins == null)
            {
                return NotFound();
            }

            return View(skins);
        }

        // GET: Skins/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Skins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SkinId,Title,Price,Stock,Category")] Skins skins)
        {
            if (ModelState.IsValid)
            {
                _context.Add(skins);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(skins);
        }

        // GET: Skins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Skins == null)
            {
                return NotFound();
            }

            var skins = await _context.Skins.FindAsync(id);
            if (skins == null)
            {
                return NotFound();
            }
            return View(skins);
        }

        // POST: Skins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SkinId,Title,Price,Stock,Category")] Skins skins)
        {
            if (id != skins.SkinId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(skins);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SkinsExists(skins.SkinId))
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
            return View(skins);
        }

        // GET: Skins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Skins == null)
            {
                return NotFound();
            }

            var skins = await _context.Skins
                .FirstOrDefaultAsync(m => m.SkinId == id);
            if (skins == null)
            {
                return NotFound();
            }

            return View(skins);
        }

        // POST: Skins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Skins == null)
            {
                return Problem("Entity set 'ShopperDbContext.Skins'  is null.");
            }
            var skins = await _context.Skins.FindAsync(id);
            if (skins != null)
            {
                _context.Skins.Remove(skins);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SkinsExists(int id)
        {
          return _context.Skins.Any(e => e.SkinId == id);
        }
    }
}
