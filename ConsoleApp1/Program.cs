using System;

namespace ConsoleApp1
{
    class Program
    {
        class Dog
        {
            string name;
            int spots;
            double happiness;

            public Dog(string _name, int _spots)
            {
                name = _name;
                spots = _spots;
                happiness = 0;
                Console.WriteLine($"The dog {name} with {spots} spots has been created");
            }

            //getters for class properties
            public string Name
            {
                get { return name; }
            }
            public int Spots
            {
                get { return spots; }
            }
            public double Happiness
            {
                get { return happiness; }
            }
            public void Barks()
            {
                Console.WriteLine("Woof-woof!");
                happiness += 0.2;
            }
            public void Tailwag()
            {
                Console.WriteLine("wiggle-wiggle");
                happiness += 0.2;
            }
            public void Rename(string newName)
            {
                name = newName;
            }
        }
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Jax", 12);
            while (myDog.Happiness != 1)
            {
                myDog.Barks();
            }
            myDog.Tailwag();
            Console.WriteLine("Rename your dog");
            string userInput = Console.ReadLine();
            myDog.Rename(userInput);
            Console.WriteLine($"Name: {myDog.Name}");
            Console.WriteLine($"Level of hapiness: {myDog.Happiness}");
            
        }
    }
}
