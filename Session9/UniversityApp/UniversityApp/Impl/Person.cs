using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.Base;

namespace UniversityApp.Impl {
    public class Person : Entity {

        //properties
         
        public string Name;
        public int Age { get; set; }
        //constructor
        public Person():base() {
            
        }
        //methods
        public virtual string GetName() {
            return Name;
        }
        public virtual void SetName(string name) {
            Name = name;
        }
    }
}
