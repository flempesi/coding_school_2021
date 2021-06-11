using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.Base;

namespace UniversityApp.Impl {
    public class Grade : Entity{
        //properties
        
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int Value { get; set; }
        //constructor
        public Grade() : base() {
             
        }

    }

}
