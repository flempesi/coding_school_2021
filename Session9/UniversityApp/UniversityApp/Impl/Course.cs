using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.Base;
namespace UniversityApp.Impl {
    public class Course : Entity {
        //propeties
         
        public string Code { get; set; }
        public string Subject { get; set; }
        //constructor
        public Course() : base(){
           
        }
    }
}
