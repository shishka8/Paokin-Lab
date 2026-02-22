using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LABA5555
{
    public partial class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=ModelDB2")
        {
        }

        public virtual DbSet<Motobike_csv> Motobike_csv { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
