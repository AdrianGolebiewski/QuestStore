using QuestStore3.Models;
using Microsoft.EntityFrameworkCore;



namespace QuestStore3.Data
{
    public class QuestContext : DbContext
    {
        public QuestContext(DbContextOptions<QuestContext> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Bonus> Bonuse { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Quest> Quest { get; set; }
        public DbSet<GroupAssignment> GroupAssignment { get; set; }
        public DbSet<QuestAssignment> QuestAssignment { get; set; }
        public DbSet<BonusAssignment> BonusAssignment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Quest>().ToTable("Quest");
            //modelBuilder.Entity<QuestAssignment>().ToTable("QuestAssignment");
            //modelBuilder.Entity<BonusAssignment>().ToTable("BonusAssignment");
            //modelBuilder.Entity<Mentor>().ToTable("Mentor");
            //modelBuilder.Entity<Student>().ToTable("Student");
            //modelBuilder.Entity<Group>().ToTable("Group");
            //modelBuilder.Entity<Admin>().ToTable("Admin");
            //modelBuilder.Entity<Bonus>().ToTable("Bonus");

            //    //modelBuilder.Entity<CourseAssignment>()
            //    //    .HasKey(c => new { c.CourseID, c.InstructorID });
        }
    
    }
}

