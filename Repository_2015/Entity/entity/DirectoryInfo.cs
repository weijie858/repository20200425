namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DirectoryInfo")]
    public partial class DirectoryInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DirectoryInfo()
        {
            DirectoryInfo1 = new HashSet<DirectoryInfo>();
            fileInfo = new HashSet<fileInfo>();
        }

        [Key]
        public Guid FileSystemID { get; set; }

        public Guid? parentId { get; set; }

        public int? sort { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DirectoryInfo> DirectoryInfo1 { get; set; }

        public virtual DirectoryInfo DirectoryInfo2 { get; set; }

        public virtual FileSystemInfo FileSystemInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fileInfo> fileInfo { get; set; }
    }
}
