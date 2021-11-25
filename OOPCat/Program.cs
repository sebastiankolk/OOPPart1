using System;

namespace OOPCat
{
    class Program
    {
        class Cat
        {
            string name;
            string color;
            double hungriness;

            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                hungriness = 0;
                Console.WriteLine($"The cat {name} with the color {color} has been created");
            }
            public string Name
            {
                get { return name; }
            }
            public string Color
            {
                get { return color; }
            }
            public double Hungriness
            {
                get { return hungriness; }
            }
            public void Sleep()
            {
                Console.WriteLine("'Zzz'");
                hungriness += 0.2;
            }
            public void Meow()
            {
                Console.WriteLine("Meow");
            }
        }
        static void Main(string[] args)
        {
            Cat myCat = new Cat("Elizabeth", "white");
            while (myCat.Hungriness != 1)
            {
                myCat.Sleep();
                if(myCat.Hungriness >= 1)
                {
                    myCat.Meow();
                }
            }
            Console.WriteLine($"Name: {myCat.Name}");
            Console.WriteLine($"Level of hungriness: {myCat.Hungriness}");
        }
    }
}
