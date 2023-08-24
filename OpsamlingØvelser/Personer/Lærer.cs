using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpsamlingØvelser.Personer
{
    public class Lærer : Person
    {
        public string Fag { get; set; }

        public override string ShowMyIdentity()
        {
            return "Jeg er en lærer.";
        }
    }

}
