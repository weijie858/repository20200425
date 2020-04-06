namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 议程
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 议程()
        {
            员工1 = new HashSet<员工>();
        }

        public Guid 议程ID { get; set; }

        public Guid? 创建者ID { get; set; }

        public Guid? 议程类型ID { get; set; }

        [StringLength(255)]
        public string 主题 { get; set; }

        [StringLength(10)]
        public string 地点 { get; set; }

        public DateTime? 开始日期 { get; set; }

        public DateTime? 结束日期 { get; set; }

        [StringLength(500)]
        public string 内容 { get; set; }

        public DateTime? 创建日期 { get; set; }

        public bool? 公开 { get; set; }

        public virtual 议程类型 议程类型 { get; set; }

        public virtual 员工 员工 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<员工> 员工1 { get; set; }
    }
}
