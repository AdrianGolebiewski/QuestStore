using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuestStore3.Data;
using QuestStore3.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Caching.Memory;

namespace QuestStore3.Controllers
{
    [Authorize(Roles = "Mentor")]
    [ApiController]
    [Route("api/[controller]")]
    public class MentorController : Controller
    {
        private readonly QuestContext _context;
        private readonly GroupsController _group;
        private readonly GroupAssignment _groupAssignment;

        public MentorController(QuestContext context, GroupsController group, GroupAssignment groupAssignment)
        {
            _context = context;
            _group = group;
            _groupAssignment = groupAssignment;
        }

            

        public async Task<IActionResult> EditGroup(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @group = await _context.Group.FindAsync(id);
            if (@group == null)
            {
                return NotFound();
            }
            return View(@group);
        }

        [HttpGet]
        public IEnumerable<User> GetStudents()
        {
            var mentorId = User.FindFirst(claim => claim.Type == System.Security.Claims.ClaimTypes.SerialNumber)?.Value;
            var mentorGroupId = _context.Group.Where(g => g.MentorId.ToString() == mentorId).ToList();
            var userList = new List<User>();


            foreach (Group g in mentorGroupId)
            {
                _context.GroupAssignment.Where(g => g.GroupID == g.GroupID).Load();
                foreach (GroupAssignment item in g.GroupAssignment)
                {
                    var x = _context.User.Where(u => u.ID == item.UserID).FirstOrDefault();
                    userList.Add(x);

                }
                return userList;
            }
            return null;

             


        }

      

       

    }


        } 

