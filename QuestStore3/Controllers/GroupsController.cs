using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuestStore3.Models;

namespace QuestStore3.Data
{
    [ApiController]
    [Route("api/[controller]")]
    public class GroupsController : Controller
    {
        private readonly QuestContext _context;
        private readonly GroupAssignment _groupAssignment;


        public GroupsController(QuestContext context, GroupAssignment groupAssignment)
        {
            _context = context;
            _groupAssignment = groupAssignment;
        }

        [HttpGet]
        public async Task<IEnumerable<Group>> Get()
        {
            var userRole = User.FindFirst(claim => claim.Type == System.Security.Claims.ClaimTypes.Role)?.Value;
            var userId = User.FindFirst(claim => claim.Type == System.Security.Claims.ClaimTypes.SerialNumber)?.Value;
            var groupList = new List<Group>();

            if (userRole == "Admin")
            {
                return await _context.Group.ToListAsync();
            }
            else if (userRole == "Mentor")
            {
                return await _context.Group.Where(s => s.MentorId.ToString() == userId).ToListAsync();
            }
            else if (userRole == "Student")
            {
                var studentGroup = _context.GroupAssignment.Where(s => s.UserID.ToString() == userId).ToList();
                foreach (var item in studentGroup)
                {
                    groupList.Add(_context.Group.Where(g => g.GroupID == item.GroupID).FirstOrDefault());                 
                }

                return groupList;

            }
            return null;
        }


        //[Authorize(Roles = "Admin,Mentor")]
        //public IActionResult CreateGroup()
        //{
        //    return View();
        //}
     
        [Authorize(Roles = "Admin,Mentor")]
        [HttpPost]
        public async Task<bool> CreateGroup(Group group)
        {
            if (ModelState.IsValid)
            {
                group.MentorId = Int32.Parse(User.FindFirst(claim => claim.Type == System.Security.Claims.ClaimTypes.SerialNumber)?.Value);
                _context.Add(group);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;   
        }

        //public async Task<IActionResult> MyGroup()
        //{
        //    var mentorId = User.FindFirst(claim => claim.Type == System.Security.Claims.ClaimTypes.SerialNumber)?.Value;
        //    return View(await _context.Group.Where(s => s.MentorId.ToString() == mentorId).ToListAsync());

        //}

        [Route("details")]
        [HttpPost]
        public async Task<IEnumerable<User>> Details(Group id)
        {
            //if (id == null)
            //{
            //    return null;
            //}

            //var group = await _context.Group
            //    .FirstOrDefaultAsync(m => m.GroupID == id);

            //if (@group == null)
            //{
            //    return null;
            //}

            var userList = new List<User>();
            var s = await _context.GroupAssignment.Where(u => u.GroupID == id.GroupID).ToListAsync();

            foreach (var user in s)
            {
                var x = _context.User.Where(u => u.ID == user.UserID).FirstOrDefault();
                userList.Add(x);
            }



            return userList;
        }

        //// GET: Groups/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //[Authorize(Roles = "Admin,Mentor")]
        //[HttpPost]
        //public async Task<IActionResult> Create([Bind("GroupID,Name,Description")] Group @group)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(@group);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(@group);
        //}

        //[Authorize(Roles = "Admin,Mentor")]
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var @group = await _context.Group.FindAsync(id);
        //    if (@group == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(@group);
        //}

        //[Authorize(Roles = "Admin,Mentor")]
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("GroupID,Name,Description")] Group @group)
        //{
        //    if (id != @group.GroupID)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(@group);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!GroupExists(@group.GroupID))
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
        //    return View(@group);
        //}

        //[Authorize(Roles = "Admin,Mentor")]
        //public IActionResult AddToGroup()
        //{

        //    return View(_context.User.Where(s => s.Role == Role.Student).ToList());

        //}

        //[Authorize(Roles = "Admin,Mentor")]
        //[HttpPost]
        //public async Task<IActionResult> AddToGroup(int id, List<User> usersList)
        //{
        //    foreach (var user in usersList)
        //    {
        //        _groupAssignment.UserID = user.ID;
        //        _groupAssignment.GroupID = id;
        //        _groupAssignment.ID = 0;

        //        if (_context.GroupAssignment.Where(m => m.UserID == user.ID && m.GroupID == id).FirstOrDefault() == null)
        //        {
        //            _context.Add(_groupAssignment);
        //            await _context.SaveChangesAsync();
        //        }

        //    }

        //    return RedirectToAction(nameof(Index));
        //}

        //[Authorize(Roles = "Admin,Mentor")]
        //// GET: Groups/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var @group = await _context.Group
        //        .FirstOrDefaultAsync(m => m.GroupID == id);
        //    if (@group == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(@group);
        //}

        //[Authorize(Roles = "Admin,Mentor")]
        //// POST: Groups/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var @group = await _context.Group.FindAsync(id);
        //    _context.Group.Remove(@group);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool GroupExists(int id)
        {
            return _context.Group.Any(e => e.GroupID == id);
        }
    }
}
