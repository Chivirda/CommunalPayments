using System.Data.Entity;

namespace ProgramLogic.Model
{
    public class CPContext : DbContext
    {
        public CPContext() : base("DBConnection") { }

        public DbSet<House> Houses { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<Result> Results { get; set; }
    }
}
