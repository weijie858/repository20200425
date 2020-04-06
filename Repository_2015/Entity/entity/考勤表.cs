namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 考勤表
    {
        [Key]
        public Guid 考勤ID { get; set; }

        public Guid? 员工ID { get; set; }

        public DateTime? 打卡日期 { get; set; }

        [StringLength(255)]
        public string 备注 { get; set; }

        public int? 打卡类别 { get; set; }

        public virtual 员工 员工 { get; set; }
    }
}
