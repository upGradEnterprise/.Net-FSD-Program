using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public partial class Sept2024DbContext : DbContext
{
    public Sept2024DbContext()
    {
    }

    public Sept2024DbContext(DbContextOptions<Sept2024DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dept> Depts { get; set; }

    public virtual DbSet<Emp> Emps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dept>(entity =>
        {
            entity.HasKey(e => e.Deptno).HasName("PK_Dept_Deptno");

            entity.ToTable("Dept");

            entity.Property(e => e.Deptno).ValueGeneratedNever();
            entity.Property(e => e.Dname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Loc)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Emp>(entity =>
        {
            entity.HasKey(e => e.Empno).HasName("PK_EMPS_EMPNO");

            entity.HasIndex(e => e.Ename, "Ename_Index3");

            entity.HasIndex(e => new { e.Ename, e.Job }, "Ename_Job_Index");

            entity.HasIndex(e => e.Deptno, "deptno_filter_index").HasFilter("([deptno]=(10))");

            entity.Property(e => e.Empno)
                .ValueGeneratedNever()
                .HasColumnName("empno");
            entity.Property(e => e.Deptno).HasColumnName("deptno");
            entity.Property(e => e.Ename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.Salary).HasColumnName("salary");

            entity.HasOne(d => d.Dept).WithMany(p => p.Emps)
                .HasForeignKey(d => d.Deptno)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_EMPS_DEPTS");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
