namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 菜单项
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 菜单项()
        {
            菜单项1 = new HashSet<菜单项>();
            角色的菜单 = new HashSet<角色的菜单>();
        }

        public Guid 菜单项ID { get; set; }

        public Guid? 上级菜单项ID { get; set; }

        [Required]
        [StringLength(255)]
        public string 名称 { get; set; }

        [StringLength(255)]
        public string 描述 { get; set; }

        [StringLength(255)]
        public string URL { get; set; }

        public int? 排序 { get; set; }

        [StringLength(255)]
        public string 图标URL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<菜单项> 菜单项1 { get; set; }

        public virtual 菜单项 菜单项2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<角色的菜单> 角色的菜单 { get; set; }
    }
}
