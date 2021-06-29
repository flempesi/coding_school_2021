using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppDotNet5.Model {
    public class Student :EntityBase {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? BirtDate { get; set; }
        public string Address { get; set; }
      
        public ICollection<StudentCourse> StudentsCourses { get; set; }
        public Student() {
            BirtDate = new DateTime(1990, 1, 1);
        }
       
    }
}
