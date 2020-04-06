namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 文件类型
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 文件类型()
        {
            fileInfo = new HashSet<fileInfo>();
        }

        public Guid 文件类型ID { get; set; }

        [Required]
        [StringLength(255)]
        public string 名称 { get; set; }

        [StringLength(12)]
        public string 扩展名 { get; set; }

        [StringLength(255)]
        public string 图标URL { get; set; }

        public int? 排序 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fileInfo> fileInfo { get; set; }
    }
}
