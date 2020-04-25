namespace Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class oamodel : DbContext
    {
        public oamodel()
            : base("name=oaModel")
        {
        }

        public virtual DbSet<DirectoryInfo> DirectoryInfo { get; set; }
        public virtual DbSet<fileInfo> fileInfo { get; set; }
        public virtual DbSet<FileSystemInfo> FileSystemInfo { get; set; }
        public virtual DbSet<便签> 便签 { get; set; }
        public virtual DbSet<部门> 部门 { get; set; }
        public virtual DbSet<菜单项> 菜单项 { get; set; }
        public virtual DbSet<机构> 机构 { get; set; }
        public virtual DbSet<角色的菜单> 角色的菜单 { get; set; }
        public virtual DbSet<考勤表> 考勤表 { get; set; }
        public virtual DbSet<权限> 权限 { get; set; }
        public virtual DbSet<文件类型> 文件类型 { get; set; }
        public virtual DbSet<消息> 消息 { get; set; }
        public virtual DbSet<消息接收人> 消息接收人 { get; set; }
        public virtual DbSet<消息类型> 消息类型 { get; set; }
        public virtual DbSet<议程> 议程 { get; set; }
        public virtual DbSet<议程类型> 议程类型 { get; set; }
        public virtual DbSet<员工> 员工 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DirectoryInfo>()
                .HasMany(e => e.DirectoryInfo1)
                .WithOptional(e => e.DirectoryInfo2)
                .HasForeignKey(e => e.parentId);

            modelBuilder.Entity<DirectoryInfo>()
                .HasMany(e => e.fileInfo)
                .WithOptional(e => e.DirectoryInfo)
                .HasForeignKey(e => e.Dir_FileSystemID);

            modelBuilder.Entity<FileSystemInfo>()
                .HasOptional(e => e.DirectoryInfo)
                .WithRequired(e => e.FileSystemInfo);

            modelBuilder.Entity<FileSystemInfo>()
                .HasOptional(e => e.fileInfo)
                .WithRequired(e => e.FileSystemInfo);

            modelBuilder.Entity<部门>()
                .HasMany(e => e.员工1)
                .WithOptional(e => e.部门1)
                .HasForeignKey(e => e.所在部门ID);

            modelBuilder.Entity<菜单项>()
                .HasMany(e => e.菜单项1)
                .WithOptional(e => e.菜单项2)
                .HasForeignKey(e => e.上级菜单项ID);

            modelBuilder.Entity<菜单项>()
                .HasMany(e => e.角色的菜单)
                .WithRequired(e => e.菜单项)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<权限>()
                .Property(e => e.图标)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<消息>()
                .HasMany(e => e.消息接收人)
                .WithRequired(e => e.消息)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<议程>()
                .Property(e => e.地点)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<议程>()
                .HasMany(e => e.员工1)
                .WithMany(e => e.议程1)
                .Map(m => m.ToTable("议程参与人").MapLeftKey("议程ID").MapRightKey("员工ID"));

            modelBuilder.Entity<员工>()
                .HasMany(e => e.部门)
                .WithRequired(e => e.员工)
                .HasForeignKey(e => e.部门负责人ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<员工>()
                .HasMany(e => e.消息)
                .WithOptional(e => e.员工)
                .HasForeignKey(e => e.消息发送人ID);

            modelBuilder.Entity<员工>()
                .HasMany(e => e.消息接收人)
                .WithRequired(e => e.员工)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<员工>()
                .HasMany(e => e.议程)
                .WithOptional(e => e.员工)
                .HasForeignKey(e => e.创建者ID);
        }
    }
}
