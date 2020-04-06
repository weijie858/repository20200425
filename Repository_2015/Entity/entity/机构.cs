namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 机构
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 机构()
        {
            部门 = new HashSet<部门>();
        }

        public Guid 机构ID { get; set; }

        [StringLength(255)]
        public string 名称 { get; set; }

        [StringLength(255)]
        public string 简称 { get; set; }

        public int? 排序 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<部门> 部门 { get; set; }
    }
}
