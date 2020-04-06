namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 便签
    {
        public Guid 便签ID { get; set; }

        public Guid? 员工ID { get; set; }

        [StringLength(255)]
        public string 标题 { get; set; }

        [StringLength(255)]
        public string 内容 { get; set; }

        public DateTime? 添加时间 { get; set; }

        public virtual 员工 员工 { get; set; }
    }
}
