using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppDotNet5.EF.Configuration;
using WinFormsAppDotNet5.Model;

namespace WinFormsAppDotNet5.EF.Context {
    class UniAppContext : DbContext{
        public UniAppContext() : base (){

        }

        public UniAppContext(DbContextOptions options) : base(options) {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=WinFormAppDotNet5DB;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Student> Courses { get; set; }



    }
}
