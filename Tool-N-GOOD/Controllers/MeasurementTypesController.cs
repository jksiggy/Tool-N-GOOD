﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tool_N_GOOD.Data;
using Tool_N_GOOD.Models;

namespace Tool_N_GOOD.Controllers
{
    public class MeasurementTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MeasurementTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MeasurementTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.MeasurementTypes.ToListAsync());
        }

        // GET: MeasurementTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var measurementType = await _context.MeasurementTypes
                .FirstOrDefaultAsync(m => m.MeasurementTypeId == id);
            if (measurementType == null)
            {
                return NotFound();
            }

            return View(measurementType);
        }

        // GET: MeasurementTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MeasurementTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MeasurementTypeId,Type")] MeasurementType measurementType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(measurementType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(measurementType);
        }

        // GET: MeasurementTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var measurementType = await _context.MeasurementTypes.FindAsync(id);
            if (measurementType == null)
            {
                return NotFound();
            }
            return View(measurementType);
        }

        // POST: MeasurementTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MeasurementTypeId,Type")] MeasurementType measurementType)
        {
            if (id != measurementType.MeasurementTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(measurementType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MeasurementTypeExists(measurementType.MeasurementTypeId))
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
            return View(measurementType);
        }

        // GET: MeasurementTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var measurementType = await _context.MeasurementTypes
                .FirstOrDefaultAsync(m => m.MeasurementTypeId == id);
            if (measurementType == null)
            {
                return NotFound();
            }

            return View(measurementType);
        }

        // POST: MeasurementTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var measurementType = await _context.MeasurementTypes.FindAsync(id);
            _context.MeasurementTypes.Remove(measurementType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MeasurementTypeExists(int id)
        {
            return _context.MeasurementTypes.Any(e => e.MeasurementTypeId == id);
        }
    }
}
