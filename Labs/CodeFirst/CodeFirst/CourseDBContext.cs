using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class CourseDBContext : DbContext
    {
        public CourseDBContext()
        {
        }

        public CourseDBContext(DbContextOptions<CourseDBContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Course> Course { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     => optionsBuilder.UseSqlServer("Data Source=DESKTOP-CUO3FKB;Initial Catalog=CourseDB;Integrated Security=True;TrustServerCertificate=True");

    }

}
