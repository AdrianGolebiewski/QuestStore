

namespace QuestStore3.Models
{
    public class QuestAssignment
    {
        public int ID { get; set; }
        public int QuestID { get; set; }
        public int StudentID { get; set; }

        public Quest Quest { get; set; }
        public User User { get; set; }
    }
}
