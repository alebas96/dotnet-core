using sede.corp;
using System;
using sede.corp; // to refer in Employee class 
using System.Collections;

namespace CarDotNet
{

    #region structures
    struct Student //do not support inheritance, null reference [value types]
    {
        public string Name;
        public string Surname;
        //can contain function
    }
    #endregion

    class Program
    {
        // to built the program navigate to the folder than type; dotnet build
        //  then navigate to the folder Debug name of the program and type; dotnet <Name>.dll

        //to watch inside the exe file use ildasm command prom devepoer command prompt

        #region delegates
            //delegate is an object to delegate function with similar signature [void () no input params in this case] and then execute them dynamicaly
        delegate void Invoker();
        #endregion
        static void Main(string[] args)
        {
            
        Car lambo = new Car("","");
        // sede.corp.Employee employee = new sede.corp.Employee();
        //or
        Employee employee = new Employee();
            #region Intefaces and reference
            /*
             * ciascuna referenza sarà un instanza delle interface. 
             */
            IBulkOperation emplyoes = new Employee();
            // Employee employee has the same method implemented from the intefaces
            emplyoes.InsertAll();
            IOperation operations = new Employee(); 
            #endregion

            #region types - flow controll
            int[,] matrix = new int[2, 3]; // [,] to define a matrix
                                           //datatypes
            /*
             * signed integral: sbyte, shor. int, long
             * unsigned: byte,ushort, uint, ulong
             * char
             * float, duble
             * bool
             * Enum Types: 
             * Struct types
             * Nullable value types
             */

            //reftype
            /* 
             * string 
             * array
             * class: obj
             * interface
             * 
             */

            /*
             * 
             * Goto
             * Continue
             * Else if ladder
             */


            //Structures

            /*
             * it is a suser definded collection of heterogeneous data type elements
             * use period tu access an element of the structure
             * 
             */

            //var vs dynamic
            /*
             * var is a static type. it defines the variable type at compile time
             * var type is fixed with initialization
             * 
             * dynamic is a runtime dispash type, it identifies the variable type at runtime
             * dynamic type can CHANGE where required acording to your instructions 
             */
            #endregion

            #region Collection classes
        // store multimple obj with different types which need a cast if you access them Stack are not TYPE SAFE
            Stack s = new Stack(3);
            s.Push(employee);
            s.Push(lambo);
            s.Push(emplyoes);
            s.Pop(); //removes the last one
                     // use queue instead
            Queue q = new Queue(); // defalut size is 32
            q.Enqueue(emplyoes);
            q.Enqueue(lambo);

            var deq = (Employee) q.Dequeue(); // to remove the last element, and now deq contains the obj of type Employee, otherwise it would have been just a generic object{}
            #endregion
            #region delegates - inkoke
            //initialized the delegation as an obj and associate a function name with a similar signature, they can be used with Anonymouse Functions
            Invoker Employer = new Invoker(employee.getAll);
            //Employer.Invoke()
            Employer(); //to execute the delegation method previously added 

            //if we want to add more methods
            Employer += new Invoker(employee.InsertAll);
            Employer += new Invoker(employee.create);
            Employer -= new Invoker(employee.getAll);
            Employer += new Invoker(()=>{   //anonymouse funciton lamba expression can be added to a delegate
                Console.WriteLine("hello");
            });
            //with one line of code we can execute all the methods at once
            Employer();
        /* pointer to a function or a method
         *  add more function to a pointer(delegate) called musticast delegates 
         *  a delegate is a type that safely encapsulates a method, and it obj oriented:; Encapsulation is more about "How" to achieve a functionality
         *  Delegate types are sealed—they cannot be derived from— and it is not possible to derive custom classes from Delegate.
         */
        #endregion



        //goto exable
        L: { Console.WriteLine("Press any Key to Exit");
                Console.ReadKey(); }

            switch (lambo.getMark())
            {
                case "Lamborghini":
                    Console.WriteLine("La marcha è {0}", lambo.getMark());  //easy to understand {n} index of the ordered arguments ...args
                    break;
                case null:

                    #region runtime polymorphism
                    //this is called runtime polymorphism because on user's input/runtime the abstract class can be derived from an class. this can change type depending from the runting flow user's decision
                    Airplane F24; // can be created the referenc of an abstract methods
                    F24 = new ArmyAirplane("F24"); // creating an obj by using a class which inherits airplane abstract class
                    F24.show();
                    break;
                #endregion

                default:
                    goto L; // L is the label where to go
            }
            
            //cw alias for console.writeline
        }
    }
}

