using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KiemTraMVC.Data;
using KiemTraMVC.Models;

namespace KiemTraMVC.Controllers
{
    public class nguyenchithanhController : Controller
    {
        private readonly ApplicationDbContext _context;

        public nguyenchithanhController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: nguyenchithanh
        public async Task<IActionResult> Index()
        {
            return View(await _context.nguyenchithanh.ToListAsync());
        }

        // GET: nguyenchithanh/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nguyenchithanh = await _context.nguyenchithanh
                .FirstOrDefaultAsync(m => m.ID == id);
            if (nguyenchithanh == null)
            {
                return NotFound();
            }

            return View(nguyenchithanh);
        }

        // GET: nguyenchithanh/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: nguyenchithanh/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Email,HoVaTen")] nguyenchithanh nguyenchithanh)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nguyenchithanh);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nguyenchithanh);
        }

        // GET: nguyenchithanh/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nguyenchithanh = await _context.nguyenchithanh.FindAsync(id);
            if (nguyenchithanh == null)
            {
                return NotFound();
            }
            return View(nguyenchithanh);
        }

        // POST: nguyenchithanh/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,Email,HoVaTen")] nguyenchithanh nguyenchithanh)
        {
            if (id != nguyenchithanh.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nguyenchithanh);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!nguyenchithanhExists(nguyenchithanh.ID))
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
            return View(nguyenchithanh);
        }

        // GET: nguyenchithanh/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nguyenchithanh = await _context.nguyenchithanh
                .FirstOrDefaultAsync(m => m.ID == id);
            if (nguyenchithanh == null)
            {
                return NotFound();
            }

            return View(nguyenchithanh);
        }

        // POST: nguyenchithanh/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nguyenchithanh = await _context.nguyenchithanh.FindAsync(id);
            if (nguyenchithanh != null)
            {
                _context.nguyenchithanh.Remove(nguyenchithanh);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool nguyenchithanhExists(string id)
        {
            return _context.nguyenchithanh.Any(e => e.ID == id);
        }
    }
}
