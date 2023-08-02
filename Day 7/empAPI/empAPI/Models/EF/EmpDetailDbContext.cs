using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace empAPI.Models.EF;

public partial class EmpDetailDbContext : DbContext
{
    public EmpDetailDbContext()
    {
    }

    public EmpDetailDbContext(DbContextOptions<EmpDetailDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DeptInfo> DeptInfos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=empDetailDB;integrated security=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DeptInfo>(entity =>
        {
            entity.HasKey(e => e.DeptNo).HasName("PK__deptInfo__BE2D3F5569A803ED");

            entity.ToTable("deptInfo");

            entity.Property(e => e.DeptNo)
                .ValueGeneratedNever()
                .HasColumnName("deptNo");
            entity.Property(e => e.DeptCity)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("deptCity");
            entity.Property(e => e.DeptName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("deptName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
