using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuestStore3.Data;
using QuestStore3.Models;
using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace QuestStore3.Controllers
{
    [Authorize(Roles = "Admin")]
    [ApiController]
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private readonly QuestContext _context;
        private readonly AccountController _register;
        private readonly User _user;
        private readonly UserEdit _userEdit;

        public UsersController(QuestContext context, AccountController register, User user, UserEdit userEdit )
        {
            _context = context;
            _register = register;
            _user = user;
            _userEdit = userEdit;
        }

        // GET: Users
        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            return await _context.User.ToArrayAsync();
        }

        //// GET: Users/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var user = await _context.User
        //        .FirstOrDefaultAsync(m => m.ID == id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(user);
        //}

        //// GET: Users/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Users/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create(User user)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        user.RegistrationDate = DateTime.UtcNow;
        //        user.Status = Status.Inactive;
        //        _context.Add(user);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(user);
        //}

        //// GET: Users/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        // {
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }
        //    var user = await _context.User.FindAsync(id);

        //   if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    _userEdit.ID = user.ID;
        //    _userEdit.FirstName = user.FirstName;
        //    _userEdit.LastName = user.LastName;
        //    _userEdit.Email = user.Email;
        //    _userEdit.PhoneNumber = user.PhoneNumber;
        //    _userEdit.Adress = user.Adress;
        //    _userEdit.Postcode = user.Postcode;
        //    _userEdit.Role = user.Role;
        //    _userEdit.Status = user.Status;
        //    _userEdit.RegistrationDate = user.RegistrationDate;
        //    return View(_userEdit);
        //}

        
        //[HttpPost]
        //public async Task<IActionResult> Edit(int id, UserEdit user)
        //{
        //    _user.ID = user.ID;
        //    _user.FirstName = user.FirstName;
        //    _user.Email = user.Email;
        //    _user.LastName = user.LastName;
        //    _user.LastName = user.Email;
        //    _user.PhoneNumber = user.PhoneNumber;
        //    _user.Adress = user.Adress;
        //    _user.Postcode = user.Postcode;
        //    _user.Role = user.Role;
        //    _user.Status = user.Status;
        //    _user.RegistrationDate = user.RegistrationDate; 

        //    if (id != user.ID)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(_user);
        //            _context.Entry(_user).Property(x => x.Password).IsModified = false;
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!UserExists(_user.ID))
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
        //    return View(user);
        //}

        //// GET: Users/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var user = await _context.User
        //        .FirstOrDefaultAsync(m => m.ID == id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(user);
        //}

        //// POST: Users/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var user = await _context.User.FindAsync(id);
        //    _context.User.Remove(user);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool UserExists(int id)
        //{
        //    return _context.User.Any(e => e.ID == id);
        //}
    }
}
