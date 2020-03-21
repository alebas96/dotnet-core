using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace AsyncBreakfast
{
    class Bacon
    {
        public int slice { get; set; }
        
        public Bacon (int slices)
        {
            this.slice = slices;
        }
        public Bacon Fry(int slices)

        {
            if(slices> this.slice)
            {
                return new Bacon(0);
            }
            
            return new Bacon(slices);
        }
    }
}
