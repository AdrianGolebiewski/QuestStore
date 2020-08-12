using System.ComponentModel.DataAnnotations.Schema;

namespace QuestStore3.Models
{
    public enum Category
    {
        A, B, C,
    }

    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public Category Category { get; set; }
        public int Amount { get; set; }
        [NotMapped]
        public bool CheckBoxAnswer { get; set; }


    }
}
