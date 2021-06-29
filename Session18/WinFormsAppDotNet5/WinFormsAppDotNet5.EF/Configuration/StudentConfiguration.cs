using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppDotNet5.Model;

namespace WinFormsAppDotNet5.EF.Configuration  {
    class StudentConfiguration : IEntityTypeConfiguration<Student> {
        public void Configure(EntityTypeBuilder<Student> builder) {
            builder.ToTable("Student", "University");

            builder.HasKey(student => student.Id);
            builder.Property(student => student.Id).ValueGeneratedOnAdd();
            builder.Property(student => student.Name).HasMaxLength(200).IsRequired(true);
            builder.Property(student => student.Surname).HasMaxLength(200).IsRequired(true);
            builder.Property(student => student.BirtDate).IsRequired(false).HasDefaultValue(new DateTime(1990, 1, 1));
            builder.Property(student => student.Address).HasMaxLength(250).IsRequired(true);
        }
    }
}
