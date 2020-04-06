namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FileSystemInfo")]
    public partial class FileSystemInfo
    {
        [Key]
        public Guid FileSystemID { get; set; }

        public Guid? 员工ID { get; set; }

        [StringLength(255)]
        public string 名称 { get; set; }

        public DateTime? 创建日期 { get; set; }

        [StringLength(255)]
        public string 备注 { get; set; }

        public virtual DirectoryInfo DirectoryInfo { get; set; }

        public virtual fileInfo fileInfo { get; set; }

        public virtual 员工 员工 { get; set; }
    }
}
