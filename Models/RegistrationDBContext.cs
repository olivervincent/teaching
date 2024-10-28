using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTeaching_RazorPages.Models
{
    public class RegistrationDBContext:DbContext
    {
         protected override void OnConfiguring(DbContextOptionsBuilder  options)
        {
            options.UseSqlServer (@"Server=localhost,1433;Database=master;User Id=sa;Password=Localhost1!;TrustServerCertificate=True;");
        }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Enrollment> Enrollments{ get; set; }
    }
}
