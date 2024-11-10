using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Inheritance
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string model) : base(model) { }
        
        

        public override void Start()
        {
            Console.WriteLine($"Starting the motorcycle: {Model}");
        }

        public override void Stop()
        {
            Console.WriteLine($"Stopping the motorcycle: {Model}");
        }

    }
}
