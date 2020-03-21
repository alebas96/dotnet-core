using System;
using System.Collections.Generic;
using System.Text;

namespace sede
{
    namespace corp
    {
        #region Interfaces
        /*
         * an interface is a pure type of abstract class interface
         * nothing get writen in a interface just defined
         * it is a reference type
         * any implementation must be placed in a class
         * 
         * 
         * support multiple implementations
         */
        interface IBulkOperation
        {
            void InsertAll();
            
        }
        interface IOperation
        {
            void getAll();
            void create();
        }
        #endregion
        class Employee:IOperation,IBulkOperation //need to implement methods of the inherited|implemented inteface
        {
            public string Name { get; set; }

            public void create()
            {
                throw new NotImplementedException();
            }

            public void getAll()
            {
                throw new NotImplementedException();
            }

            public void InsertAll()
            {
                Console.WriteLine("Inserted All");
            }
        }
    }
}
