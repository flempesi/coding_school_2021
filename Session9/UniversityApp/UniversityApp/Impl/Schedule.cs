using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.Base;

namespace UniversityApp.Impl {
    public class Schedule : Entity {   //propretie
        public Guid CourseID { get; set; }

        public Guid ProfessorID { get; set; }

        public DateTime Callendar { get; set; }

        //constructor
        public Schedule() :base() {
      
        }

    }
}
