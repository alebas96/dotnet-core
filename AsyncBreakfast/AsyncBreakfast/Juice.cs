using System;
using System.Collections.Generic;
using System.Text;

namespace AsyncBreakfast
{
    class Juice
    {
        public int glass { get; set; }
        public string type { get; set; }

        public Juice Pour (int glasses, string what) {
            
            return new Juice() { 
                glass = glasses,
                type = what
            };
        }
    }
}
