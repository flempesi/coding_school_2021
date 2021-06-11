using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp.Base {
    public class Entity {
        //properties
        public Guid ID { get; private set; }
        //constructor
        public Entity() {
            ID = Guid.NewGuid();
        }
    }

}
