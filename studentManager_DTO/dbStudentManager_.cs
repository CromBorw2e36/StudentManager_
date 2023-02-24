using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace studentManager_DTO
{
    public partial class dbStudentManager_ : DbContext
    {
        public dbStudentManager_()
            : base("data source=.;initial catalog=QLHV;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        {
        }

        public virtual DbSet<DAY_HOC> DAY_HOC { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DAY_HOC>()
                .Property(e => e.MAMON)
                .IsFixedLength();

            modelBuilder.Entity<DAY_HOC>()
                .Property(e => e.MAGIAOVIEN)
                .IsFixedLength();

            modelBuilder.Entity<DAY_HOC>()
                .Property(e => e.MADAYHOC)
                .IsFixedLength();
        }
    }
}
