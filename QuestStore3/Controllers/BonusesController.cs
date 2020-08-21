using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuestStore3.Data;
using QuestStore3.Models;

namespace QuestStore3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BonusesController : Controller
    {
        private readonly QuestContext _context;

        public BonusesController(QuestContext context)
        {
            _context = context;
        }

        // GET: Bonuses
        [HttpGet]
        public async Task<IEnumerable<Bonus>> Get()
        {
            return await _context.Bonuse.ToListAsync();
        }

        //// GET: Bonuses/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var bonus = await _context.Bonuse
        //        .FirstOrDefaultAsync(m => m.ID == id);
        //    if (bonus == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(bonus);
        //}

        //// GET: Bonuses/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Bonuses/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("ID,Name,Description,Price,Category,Amount")] Bonus bonus)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(bonus);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(bonus);
        //}

        //// GET: Bonuses/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var bonus = await _context.Bonuse.FindAsync(id);
        //    if (bonus == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(bonus);
        //}

        //// POST: Bonuses/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Description,Price,Category,Amount")] Bonus bonus)
        //{
        //    if (id != bonus.ID)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(bonus);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!BonusExists(bonus.ID))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(bonus);
        //}

        //// GET: Bonuses/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var bonus = await _context.Bonuse
        //        .FirstOrDefaultAsync(m => m.ID == id);
        //    if (bonus == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(bonus);
        //}

        //// POST: Bonuses/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var bonus = await _context.Bonuse.FindAsync(id);
        //    _context.Bonuse.Remove(bonus);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool BonusExists(int id)
        //{
        //    return _context.Bonuse.Any(e => e.ID == id);
        //}
    }
}
