using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuestStore3.Models
{
    public class Group
    {   
        public int GroupID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public int MentorId { get; set; }


        public ICollection<GroupAssignment> GroupAssignment { get; set; }




    }
}
