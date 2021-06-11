using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.Base;

namespace UniversityApp.Impl {
    public class Institute : Entity {
        //properties
        public string Name;

        public int YearsInService { get; set; }
        //constructor
        public Institute() : base(){
             
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
