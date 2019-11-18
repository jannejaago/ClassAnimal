using System;

namespace ClassAnimal
{
    class Animal
    {
        public string name;
        public int age = 0;
        public double weight;
        public int lifespan = 0;
        
        public Animal(string _name, int _age, double _weight, int _lifespan)
        {
            name = _name;
            age = _age;
            weight = _weight;
            lifespan = _lifespan;
        }
        public void PrintBasicInfo()
        {
            Console.WriteLine($"Animal name: {name}.");
            Console.WriteLine($"Animal age: {age}.");
            Console.WriteLine($"Animal weight: {weight}.");
        }

        public void Eat()
        {
            weight += 0.2;
            Console.WriteLine($"{name} is eating.");
            ShowWeight();
        }

        public void ShowWeight()
        {
            Console.WriteLine($"{name} now weights {weight}.");
        }

        public void ShowLifespan()
        {
            Console.WriteLine($"{name}'s lifespan is {lifespan}.");
            lifespan++;
            age++;
        }

        public void Exercise()
        {
            weight -= 0.1;
            Console.WriteLine($"{name} is exercising.");
            ShowWeight();
        }
    }
}
