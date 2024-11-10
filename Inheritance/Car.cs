using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Car : Vehicle
    {
        public Car(string model) : base(model) { }
       

        public override void Start()
        {
            Console.WriteLine($"Starting the car: {Model}");
        }

        public override void Stop()
        { 
            Console.WriteLine($"Stopping the car: {Model}"); 
        }
    }
}