using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppDotNet5.Model {
     public class Course : EntityBase{
        public string Title { get; set; }
        public string Category { get; set; }
        public DateTime? Date { get; set; }
        public int Duration { get; set; }


        public ICollection<StudentCourse> StudentsCourses { get; set; }
        public Course() {
            Date = new DateTime(1990, 1, 1);
        }
    }
}
