using Domain.Data.Entities;
using System.Data.Entity;

namespace Domain.Data.Contexts
{
    public class ReportContext : DbContext
    {
        public DbSet<Dodatoc1> Dodatoc1s { get; set; }
        public DbSet<Dodatoc2> Dodatoc2s { get; set; }
        public DbSet<Dodatoc4> Dodatoc4s { get; set; }
        public DbSet<Dodatoc5> Dodatoc5s { get; set; }
        public DbSet<Forma7> Forma7s { get; set; }
        public DbSet<FormaN1> FormaN1s { get; set; }
        public DbSet<FormaN5> FormaN5s { get; set; }
        public DbSet<FormaNpv> FormaNpvs { get; set; }
        public DbSet<FormaNt> FormaNts { get; set; }
        public DbSet<FormaZvt> FormaZvts { get; set; }

        public ReportContext() : base("BaseConnection")
        {

        }
    }
}
