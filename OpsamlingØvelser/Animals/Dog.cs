using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OpsamlingØvelser.Animals
{
    public class Dog : Animal
    {
        public static void MakeSound()
        {
            Console.WriteLine(" the dog says 'Woof!'");
            string myCurrentDir = System.IO.Directory.GetCurrentDirectory();
            string appDir = System.IO.Path.Combine(myCurrentDir, @"Animals\Dog.wav");

            System.Media.SoundPlayer? soundPlayer = new System.Media.SoundPlayer();
            soundPlayer.SoundLocation = appDir;
            soundPlayer.Play();
        }
    }
}
