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


namespace QuestStore3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestController : Controller
    {
        private readonly QuestContext _context;
        private readonly Quest _quest;
        private readonly QuestAssignment _questAssignment;

        public QuestController(QuestContext context, Quest quest, QuestAssignment questAssignment)
        {
            _context = context;
            _questAssignment = questAssignment;
            _quest = quest;
        }

        [HttpGet]
        public async Task<IEnumerable<Quest>> Get()

        {
            return await  _context.Quest.ToArrayAsync();
        }

      
    }
}
