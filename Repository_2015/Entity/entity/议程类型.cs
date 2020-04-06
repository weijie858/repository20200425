namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 议程类型
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 议程类型()
        {
            议程 = new HashSet<议程>();
        }

        public Guid 议程类型ID { get; set; }

        [StringLength(255)]
        public string 名称 { get; set; }

        [StringLength(255)]
        public string 排序 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<议程> 议程 { get; set; }
    }
}
