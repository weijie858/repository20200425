namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 消息接收人
    {
        [Key]
        [Column(Order = 0)]
        public Guid 消息ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid 员工ID { get; set; }

        public bool 是否已读 { get; set; }

        public bool? 是否删除 { get; set; }

        public virtual 消息 消息 { get; set; }

        public virtual 员工 员工 { get; set; }
    }
}
