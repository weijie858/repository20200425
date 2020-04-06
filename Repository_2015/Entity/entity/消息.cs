namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 消息
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 消息()
        {
            消息接收人 = new HashSet<消息接收人>();
        }

        public Guid 消息ID { get; set; }

        public Guid? 消息类型ID { get; set; }

        public Guid? 消息发送人ID { get; set; }

        [StringLength(255)]
        public string 标题 { get; set; }

        [StringLength(500)]
        public string 内容 { get; set; }

        public DateTime? 创建日期 { get; set; }

        public DateTime? 生效时间 { get; set; }

        public DateTime? 结束时间 { get; set; }

        [StringLength(255)]
        public string 发生对象 { get; set; }

        public int? 状态 { get; set; }

        public bool? 是否删除 { get; set; }

        public virtual 消息类型 消息类型 { get; set; }

        public virtual 员工 员工 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<消息接收人> 消息接收人 { get; set; }
    }
}
