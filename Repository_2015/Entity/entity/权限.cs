namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 权限
    {
        public Guid 权限ID { get; set; }

        [StringLength(10)]
        public string 图标 { get; set; }
    }
}
