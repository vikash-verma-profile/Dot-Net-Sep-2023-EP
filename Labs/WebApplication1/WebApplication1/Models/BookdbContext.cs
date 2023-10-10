using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public partial class BookdbContext : DbContext
{
    public BookdbContext()
    {
    }

    public BookdbContext(DbContextOptions<BookdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblBook> TblBooks { get; set; }

    public virtual DbSet<TblCourse> TblCourses { get; set; }

    public virtual DbSet<TblCourseBookMapping> TblCourseBookMappings { get; set; }

    public virtual DbSet<TblStudent> TblStudents { get; set; }

   

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
