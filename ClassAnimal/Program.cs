using System;

namespace ClassAnimal
{

    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Misty",0,0.3,0);

            for(int i = 0; i<10; i++)
            {
                animal.PrintBasicInfo();
                animal.ShowLifespan();
                animal.Eat();
                while (animal.weight > 0.7)
                {
                    animal.Exercise();
                }
                if (i == 9)
                {
                    Console.WriteLine("Your animal dies now because they're old, sorry. Final info:");
                    animal.PrintBasicInfo();
                    animal.ShowLifespan();
                    animal = null;
                }
            }
        }
    }
}
