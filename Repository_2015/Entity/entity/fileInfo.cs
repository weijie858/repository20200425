namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fileInfo")]
    public partial class fileInfo
    {
        [Key]
        public Guid FileSystemID { get; set; }

        public Guid? 文件类型ID { get; set; }

        public Guid? Dir_FileSystemID { get; set; }

        public double? size { get; set; }

        [StringLength(255)]
        public string url { get; set; }

        public virtual DirectoryInfo DirectoryInfo { get; set; }

        public virtual FileSystemInfo FileSystemInfo { get; set; }

        public virtual 文件类型 文件类型 { get; set; }
    }
}
