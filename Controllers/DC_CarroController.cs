using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DanielAdrianCornejo_Examen1P.Data;
using DanielAdrianCornejo_Examen1P.Models;

namespace DanielAdrianCornejo_Examen1P.Controllers
{
    public class DC_CarroController : Controller
    {
        private readonly DanielAdrianCornejo_Examen1PContext _context;

        public DC_CarroController(DanielAdrianCornejo_Examen1PContext context)
        {
            _context = context;
        }

        // GET: DC_Carro
        public async Task<IActionResult> Index()
        {
            return View(await _context.DC_Carro.ToListAsync());
        }

        // GET: DC_Carro/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dC_Carro = await _context.DC_Carro
                .FirstOrDefaultAsync(m => m.DC_CarroID == id);
            if (dC_Carro == null)
            {
                return NotFound();
            }

            return View(dC_Carro);
        }

        // GET: DC_Carro/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DC_Carro/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DC_CarroID,DC_Cantidad,DC_Marca,DC_Precio,DC_Vendido,DC_Fecha")] DC_Carro dC_Carro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dC_Carro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dC_Carro);
        }

        // GET: DC_Carro/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dC_Carro = await _context.DC_Carro.FindAsync(id);
            if (dC_Carro == null)
            {
                return NotFound();
            }
            return View(dC_Carro);
        }

        // POST: DC_Carro/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DC_CarroID,DC_Cantidad,DC_Marca,DC_Precio,DC_Vendido,DC_Fecha")] DC_Carro dC_Carro)
        {
            if (id != dC_Carro.DC_CarroID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dC_Carro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DC_CarroExists(dC_Carro.DC_CarroID))
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
            return View(dC_Carro);
        }

        // GET: DC_Carro/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dC_Carro = await _context.DC_Carro
                .FirstOrDefaultAsync(m => m.DC_CarroID == id);
            if (dC_Carro == null)
            {
                return NotFound();
            }

            return View(dC_Carro);
        }

        // POST: DC_Carro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dC_Carro = await _context.DC_Carro.FindAsync(id);
            if (dC_Carro != null)
            {
                _context.DC_Carro.Remove(dC_Carro);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DC_CarroExists(int id)
        {
            return _context.DC_Carro.Any(e => e.DC_CarroID == id);
        }
    }
}
