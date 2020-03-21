using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CarDotNet
{
    #region Inheritance - override - abstract
    class Van : Car /*
            inherit only public field and methods of a class
            it is used to extend functionality and use the father classe's medthods to fit to the new class
            protected field can be accessed from a child class

        Types of Inheritantece
        _ single: like in this case. the extented class are one to one (A):(B)
        _ multilevel: if a class is derived from a class which it is also extended. (a):(b):(c)
        _ multiple: if a class is derived form more than one class

        constructor chaining 
        
        default construc of a child always invokes default of the base class

        :base() refers to father class
        :this() refers to this class

        if you don't have a default you have to use the :base construct to invoke the constructor with the parameters
        */
    {
        public int power { get; set; }
        public double strength { get; set; }
        protected double telaio { get; set; }
        
        public Van(string make, string model, int topSpeed, DateTime manufactured) :base(make,model,topSpeed,manufactured) //this will call Car construct with :base calls the car constructor (base because is the base class where to inherit all the fields and contructors)
        {

        }

        public virtual void Details() //if you don't put virtual you can put in a case can be overriden
        {
            Console.WriteLine("details "+this.getMark());
        }
    }
  
    class Truck : Van
    {
        /*
           *  Method overriding
           * 
           *  this.method() call the (virtual) child class or current class where the method is
           *  
           *  base.method() calls the overriden class method
           *  
           *  if the method has the same implementation + more lines of code to describe more features on a child class. it can be ovveriden so it has the same signature but more features.
           */

        public int trails { get; set; }
        public string[] trailsPlateNum { get; set; }


        public Truck(string make, string model, int topSpeed, DateTime manufactured):base(make,model,topSpeed,manufactured) { } //this will call Van contrsuctor :base calls the car constructor (base because is the base class where to inherit all the fields and contructors)

        public override sealed void Details() // to override a method you put the keyword override. an takes the Van.Details() and adds lines of code
        {
            base.details();
            Console.WriteLine("truck "+this.trails);
        }

        //public abstract void SetPlateNum(); cannot be create in a non abstract class
    }

    sealed class Train : Truck //
    {
        /*
             * Seald method & class
             * 
             * if you don't wont to override a method from a derived class you should seal it.
             * you can invoke it but not override it
             * 
             * a sealed class cannot be inherited
             */

        /*
         * abstract method must be overriden
         * - it is empty, no body
         * - you should implemented
         * - if you inherit that class and you have an abstract method you should/must override it, event if it is empty on the derived class
         * 
         * 
         */

        /*
         * abstract class 
         * it say what to but not how to do it
         * no obj can be created
         * but it's reference can be created
         * 
         * must be declered with abstract keyword
         * 
         * this is call runtime polymorphism also abstract method
         */
        public Train(string make, string model, int topSpeed, DateTime manufactured) : base(make, model, topSpeed, manufactured)
        {

        }
        //public override sealed void Details() gives an error because is sealed in Truck class

    }
    /*
    class Ship : Train //throws an error because train is sealed and it cannot be derived
    {

    }
    */


    #endregion

    #region runtime | dynamic polymorphism
    /* [refers to Program.cs]
     * 
     * deriviing the abstract class by one or more and overrind all the abstract methods
     * create the reference of abstract class and making it an obj based on user's inputs and calling the methods of abstract classes
     * 
     * the method gets referred from derived class at runtime based on user input
     * this complete process is called runtime polymorphism
     */
    //this class use the abstract class to do something with it
    class ArmyAirplane : Airplane
    {
        public ArmyAirplane(string model)
        {
            this.model = model;
        }
        //must implement the show method even if it is empty

        public override void show()
        {
            Console.WriteLine("this a Military airplane"+this.model);
            throw new NotImplementedException();
        }
    }
    //this abstract class show what is the concept of the class
    abstract class Airplane
    {
        public string make { get; set; }
        public string model { get; set; }
        public int seat { get; set; }

        
        public abstract void show();
    }

    #endregion

    
}
