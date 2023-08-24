using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpsamlingØvelser.Animals
{
    public abstract class Animal
    {
        public static void ChooseAnimal()
        {
            while (true)
            {
                Console.WriteLine("First choose an animal.");
                Console.WriteLine("Type 1 for Cat");
                Console.WriteLine("Type 2 for Dog");
                string talinput = Console.ReadLine();
                if (talinput == "1")
                {
                    Cat.MakeSound();
                }
                if (talinput == "2")
                {
                    Dog.MakeSound();
                }
                else
                {
                    Console.Clear();
                }
            }
        }

    }
}
