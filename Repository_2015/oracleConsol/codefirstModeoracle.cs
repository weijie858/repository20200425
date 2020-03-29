namespace oracleConsol
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class codefirstModeoracle : DbContext
    {
        public codefirstModeoracle()
            : base("name=codefirstModeoracle")
        {
        }

        public virtual DbSet<DEPT> DEPTs { get; set; }
        public virtual DbSet<EMP> EMPs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DEPT>()
                .Property(e => e.DNAME)
                .IsUnicode(false);

            modelBuilder.Entity<DEPT>()
                .Property(e => e.LOC)
                .IsUnicode(false);

            modelBuilder.Entity<EMP>()
                .Property(e => e.ENAME)
                .IsUnicode(false);

            modelBuilder.Entity<EMP>()
                .Property(e => e.JOB)
                .IsUnicode(false);

            modelBuilder.Entity<EMP>()
                .Property(e => e.SAL)
                .HasPrecision(7, 2);

            modelBuilder.Entity<EMP>()
                .Property(e => e.COMM)
                .HasPrecision(7, 2);
        }
    }
}
