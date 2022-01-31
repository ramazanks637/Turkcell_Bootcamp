using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVSObject
{
    class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public bool IsMarried { get; set; }
        public double Weight { get; set; }

        public Adress HomeAdress { get; set; }
        public Adress WorkAdress { get; set; } 


    }
}
