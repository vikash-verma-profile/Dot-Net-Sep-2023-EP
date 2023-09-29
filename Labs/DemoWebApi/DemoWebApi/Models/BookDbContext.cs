using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DemoWebApi.Models;

public partial class BookDbContext : DbContext
{
    public BookDbContext()
    {
    }

    public BookDbContext(DbContextOptions<BookDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblBook> TblBooks { get; set; }

    public virtual DbSet<TblCourse> TblCourses { get; set; }

    public virtual DbSet<TblCourseBookMapping> TblCourseBookMappings { get; set; }

    public virtual DbSet<TblLogin> TblLogins { get; set; }

    public virtual DbSet<TblStudent> TblStudents { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-CUO3FKB;Initial Catalog=BookDB;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblBook>(entity =>
        {
            entity.ToTable("tblBook");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BookName).HasMaxLength(2000);
        });

        modelBuilder.Entity<TblCourse>(entity =>
        {
            entity.ToTable("tblCourse");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CourseName).HasMaxLength(200);
        });

        modelBuilder.Entity<TblCourseBookMapping>(entity =>
        {
            entity.ToTable("tblCourseBookMapping");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BookId).HasColumnName("BookID");
            entity.Property(e => e.CourseId).HasColumnName("CourseID");
        });

        modelBuilder.Entity<TblLogin>(entity =>
        {
            entity.ToTable("tblLogin");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Password).HasMaxLength(200);
            entity.Property(e => e.UserName).HasMaxLength(200);
        });

        modelBuilder.Entity<TblStudent>(entity =>
        {
            entity.ToTable("tblStudent");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.StudentName).HasMaxLength(2000);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
