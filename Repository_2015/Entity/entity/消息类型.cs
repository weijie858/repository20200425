namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 消息类型
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 消息类型()
        {
            消息 = new HashSet<消息>();
        }

        public Guid 消息类型ID { get; set; }

        [Required]
        [StringLength(255)]
        public string 名称 { get; set; }

        public int? 排序 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<消息> 消息 { get; set; }
    }
}
