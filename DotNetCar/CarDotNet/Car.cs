using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarDotNet
{

    class Car
    {
        string make = "Lamborghini";
        string model = "Diablo";
        int topSpeed = 100;
        DateTime manufactured = DateTime.Now;

        //method overloading | static polymorphism
        /*
         * same name different params
         * 
         * 
         */
         public void details()
        {


        }
        int _year;
        public int year //hardening 
        {
            set { if (value < 2020) { _year = value; } }
            get { return _year; }
        }

        //autoproperty and data notations to overcome the previous example
        [Required]
        [Range(0, 2020, ErrorMessage = "Anno non valido!")]
        public int years { get; set; }

        public static double ROI { get; set; }

        static Car(){ // cannot have parameter anc can have access only to static property
            ROI = 1.5;
         }
        public Car()
        {
        }
        public Car(string make, string model)
        {
            this.make = make;
            this.model = model;
        }

        public Car(string make, string model, int topSpeed, DateTime manufactured) : this(make, model) //this is refered to the constructor that has 2 input argumments
        {
            this.topSpeed = topSpeed;
            this.manufactured = manufactured;
        }

        public string getMark()
        {
            return make;
        }

        public void AdjustTopSeep(int topS)
        {
            topSpeed = topS;
        }
    }
}
