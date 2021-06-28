using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppDotNet5.Model;

namespace WinFormsAppDotNet5.EF.Configuration {
    class CourseConfiguration : IEntityTypeConfiguration<Course> {
        public void Configure(EntityTypeBuilder<Course> builder) {
            builder.ToTable("Course", "University");

            builder.HasKey(course => course.Id);
            builder.Property(course => course.Id).ValueGeneratedOnAdd();
            builder.Property(course => course.Title).HasMaxLength(200).IsRequired(true);
            builder.Property(course => course.Category).HasMaxLength(200).IsRequired(true);
            builder.Property(course => course.Date).IsRequired(false);
            builder.Property(course => course.Duration).IsRequired(true);


         }
    }
}
