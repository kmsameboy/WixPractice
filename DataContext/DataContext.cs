using System.Data.Entity;
using DataContext.Models;

namespace DataContext
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DataContext")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<DataContext>());
            Database.Initialize(true);
        }

        public DbSet<Entry> Items { get; set; }
    }
}
