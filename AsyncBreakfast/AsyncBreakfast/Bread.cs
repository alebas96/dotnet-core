using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace AsyncBreakfast
{
    class Bread
    {
        //The composition of an asynchronous operation followed by synchronous work is an asynchronous operation.Stated another way, if any portion of an operation is asynchronous, the entire operation is asynchronous.
        public int piece { get; set; }
        public List<string> adding { get; set; }

        public void Add(string something)
        {
            this.adding.Add(something);
        }
        public Bread Toast(int piece)
        {

            return new Bread() { piece = piece, adding = new List<string>()};
        }
    }
}
