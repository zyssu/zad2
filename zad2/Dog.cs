using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Dog : AnimalActions
    {
        public void Eat()
        {
            Console.WriteLine("The dog is eating");
        }

        public void Sleep()
        {
            Console.WriteLine("The dog is sleeping");
        }

        public void Drink()
        {
            Console.WriteLine("The dog is drinking water");
        }

        public void Move()
        {
            Console.WriteLine("The dog is running");
        }
        public void DogActions()
        {
            void Guard()
            {
                Console.WriteLine("The dog is guarding the house");
            }
            void Play()
            {
                Console.WriteLine("The dog is playing with the toys");
            }

            Eat();
            Sleep();
            Drink();
            Move();
            Guard();
            Play();
        }
    }
}
