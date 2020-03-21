using System;
using System.Threading.Tasks;

namespace AsyncBreakfast
{
    class Program
    {
        static async Task Main(string[] args)
        {

            //Don't block, await instead
                 Coffe cup = new Coffe();
                cup=cup.Pour(1);
                Console.WriteLine("coffee is ready");
                Eggs eggs = new Eggs(6);
                Task<Eggs> eggsTask = eggs.Fry(2);
                Console.WriteLine("eggs are ready");
                Bacon bacon = new Bacon(8);
                bacon= bacon.Fry(3);
                Console.WriteLine("bacon is ready");
            #region The composition of an asynchronous operation followed by synchronous work is an asynchronous operation. Stated another way, if any portion of an operation is asynchronous, the entire operation is asynchronous.
            Bread toast = new Bread();
                    toast = toast.Toast(2);
                toast.Add("Jam");
                toast.Add("Butter");
            #endregion  
            Console.WriteLine("toast is ready");
                Juice oj = new Juice();
                oj= oj.Pour(1, "orange");
                Console.WriteLine("oj is ready");

                Console.WriteLine("Breakfast is ready!");
        }
    }
}
