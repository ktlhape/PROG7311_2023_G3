using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Encapsulation
{
    internal class Car
    {
        string name;
        int speed;
        double fuel;

        public Car(string theName)
        {
            this.name = theName;
            speed = 0;
            fuel = 90;
        }
        public void StartEngine()
        {
            TurnMotor();
        }
        public void Drive()
        {
            Console.WriteLine("Driving " + name);
        }
        public void SpeedUp(int x)
        {
            speed += x;
            fuel -= 5 * (x * 0.05);
        }

        private void BurnFuel()
        {
            fuel--;
        }

        private void TurnMotor()
        {
            BurnFuel();
        }

        public void Dashboard()
        {
            Console.WriteLine($"Car: {name}\nDriving at {speed} KM/H" +
                $"\nCurrent Fuel: {fuel}" );
        }
	
    }
}
