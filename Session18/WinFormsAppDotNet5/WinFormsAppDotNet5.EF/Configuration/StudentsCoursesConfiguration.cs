using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppDotNet5.Model;

namespace WinFormsAppDotNet5.EF.Configuration {
    class StudentsCoursesConfiguration {


        public void Configure(EntityTypeBuilder<StudentCourse> builder) {

            builder.HasKey(sc => new { sc.StudentId, sc.CourseId});

            builder.HasOne(sc => sc.Student).WithMany(b => b.StudentsCourses).HasForeignKey(sc => sc.StudentId);

            builder.HasOne(sc => sc.Course).WithMany(b => b.StudentsCourses).HasForeignKey(sc => sc.CourseId);


        }
    }
}
