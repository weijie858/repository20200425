namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 部门
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 部门()
        {
            员工1 = new HashSet<员工>();
        }

        public Guid 部门ID { get; set; }

        public Guid? 机构ID { get; set; }

        public Guid 部门负责人ID { get; set; }

        [Required]
        [StringLength(255)]
        public string 名称 { get; set; }

        [StringLength(250)]
        public string 电话 { get; set; }

        [StringLength(255)]
        public string 传真 { get; set; }

        public virtual 机构 机构 { get; set; }

        public virtual 员工 员工 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<员工> 员工1 { get; set; }
    }
}
