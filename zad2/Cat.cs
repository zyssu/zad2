using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Cat : AnimalActions
    {
        public void Eat()
        {
            Console.WriteLine("The cat is eating");
        }

        public void Sleep()
        {
            Console.WriteLine("The cat is sleeping");
        }

        public void Drink()
        {
            Console.WriteLine("The cat is drinking milk");
        }

        public void Move()
        {
            Console.WriteLine("The cat is walking");
        }
        public void CatActions()
        {
            void Clean()
            {
                Console.WriteLine("The cat is cleaning itself");
            }
            void Hunt()
            {
                Console.WriteLine("The cat is hunting a mouse");
            }

            Eat();
            Sleep();
            Drink();
            Move();
            Clean();
            Hunt();
        }
    }
}
