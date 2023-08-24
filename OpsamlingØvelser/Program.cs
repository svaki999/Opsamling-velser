using OpsamlingØvelser.Animals;
using OpsamlingØvelser.Personer;

namespace OpsamlingØvelser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elev elev = new Elev { Navn = "Patrick", Klassetrin = "H1" };
            Lærer lærer = new Lærer { Navn = "Niels", Fag = "OOP" };

            Console.WriteLine(elev.SayHello("elev"));
            Console.WriteLine(lærer.SayHello("lærer"));

            Console.WriteLine(elev.ShowMyIdentity());
            Console.WriteLine(lærer.ShowMyIdentity());

            Animal.ChooseAnimal();
        }
    }
}