using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeMethodDesignPattern
{
    public class Car
    {
        private Engine engine = new Engine();
        private Light light = new Light();
        public void StartCar()
        {
            engine.Start();
            light.TurnOn();
            Console.WriteLine("Car is ready to drive");
        }
        public void StopCar()
        {
            light.TurnOff();
            engine.Stop();
            Console.WriteLine("Car stopped");
        }
    }
}
