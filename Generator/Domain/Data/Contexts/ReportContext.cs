using Domain.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
