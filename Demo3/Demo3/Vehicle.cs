using System;

namespace Demo3
{
    class Vehicle
    {
        private String Name { get; set; }
        private int Speed { get; set; }
        private int Tyres { get; set; }

        public Vehicle(String name, int speed, int tyres)
        {
            Name = name;
            Speed = speed;
            Tyres = tyres;
        }

        public void PrintData()
        {
            Console.WriteLine("\nName: " + this.Name);
            Console.WriteLine("Speed: " + this.Speed);
            Console.WriteLine("Tyres: " + this.Tyres);
        }

        public override string ToString()
        {
            return this.Name + this.Speed + this.Tyres;
        }
    }
}
