using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPM_SAS.Entidades;

namespace BPM_SAS.DAL
{
    public class BPM_SASContext : DbContext
    {

        public BPM_SASContext()
            : base("BPM_SASContext")
        {
        }

        public DbSet<Usuario> Usuario { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
