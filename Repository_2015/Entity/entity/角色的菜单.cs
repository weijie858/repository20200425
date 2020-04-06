namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 角色的菜单
    {
        [Key]
        [Column(Order = 0)]
        public Guid 菜单项ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string 角色名 { get; set; }

        public virtual 菜单项 菜单项 { get; set; }
    }
}
