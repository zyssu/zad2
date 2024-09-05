using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    using System;

    namespace zad2
    {
        class Program
        {
            public static void Main(string[] args)
            {
                Dog dog = new Dog();
                Cat cat = new Cat();

                Console.WriteLine("Dog actions:");
                dog.DogActions();

                Console.WriteLine("\nCat actions:");
                cat.CatActions();
            }
        }
    }
}
