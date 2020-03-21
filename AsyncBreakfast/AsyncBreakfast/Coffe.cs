using System;
using System.Collections.Generic;
using System.Text;

namespace AsyncBreakfast
{
    class Coffe
    {
        public int cup { get; set; }
        public Coffe()
        {

        }
        public Coffe(int cup)
        {
            this.cup = cup;
        }
        public Coffe Pour(int cup)
        {
            this.cup = cup;
            return new Coffe(cup);
        }

    }
}
