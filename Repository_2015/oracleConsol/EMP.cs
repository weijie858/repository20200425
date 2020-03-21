namespace oracleConsol
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SCOTT.EMP")]
    public partial class EMP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short EMPNO { get; set; }

        [StringLength(10)]
        public string ENAME { get; set; }

        [StringLength(9)]
        public string JOB { get; set; }

        public short? MGR { get; set; }

        public DateTime? HIREDATE { get; set; }

        public decimal? SAL { get; set; }

        public decimal? COMM { get; set; }

        public byte? DEPTNO { get; set; }

        public virtual DEPT DEPT { get; set; }
    }
}
