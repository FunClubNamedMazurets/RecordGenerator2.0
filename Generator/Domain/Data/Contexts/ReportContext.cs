using Domain.Data.Entities;
using System.Data.Entity;

namespace Domain.Data.Contexts
{
    public class ReportContext : DbContext
    {
        public DbSet<Dodatoc2> Dodatoc2s { get; set; }

        public DbSet<Dodatoc4> Dodatoc4s { get; set; }

        public ReportContext() : base("BaseConnection")
        {

        }
    }
}
