using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Car
    {
        bool status = false;
        public void Run()
        {
            status = true;
        }

        public void Stop()
        {
            status = false;
        }

        public bool getStatus()
        {
            return status;
        }
    }

    class Excavator : Car
    {
        public void Dig()
        {
            Console.WriteLine("掘ってます");
        }

        public void Bring()
        {
            Console.WriteLine("運んでます");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Run();
            Console.WriteLine(car.getStatus());
            car.Stop();
            Console.WriteLine(car.getStatus());

            Excavator excavator = new Excavator();
            excavator.Dig();
            excavator.Bring();
            excavator.Run();
            Console.WriteLine(excavator.getStatus());
        }
    }
}
