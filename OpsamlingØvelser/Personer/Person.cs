using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpsamlingØvelser.Personer
{
    public abstract class Person
    {
        public string Navn { get; set; }

        public string SayHello(string type)
        {
            return $"Hej, jeg er en {type}. Mit navn er {Navn}.";
        }

        public abstract string ShowMyIdentity();
    }

}
