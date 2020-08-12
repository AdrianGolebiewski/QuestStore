using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestStore3.Models
{
    public class BonusAssignment
    {
        public int ID { get; set; }
        public int BonusID { get; set; }
        public int UserID { get; set; }

        public Bonus Bonus { get; set; }
        public User User { get; set; }
    }
}
