using System;
using System.Collections.Generic;
using System.Text;

namespace AsyncBreakfast
{
    class Eggs
    {
        public int count { get; set; }

        public Eggs(int count)
        {
            this.count = count;
        }
        public Eggs Fry(int count)

        {
            if (count > this.count)
            {
                return new Eggs(0);
            }
            
            return new Eggs(count);
        }
    }
}
