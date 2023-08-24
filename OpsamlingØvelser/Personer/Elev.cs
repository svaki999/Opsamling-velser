using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpsamlingØvelser.Personer
{
    public sealed class Elev : Person
    {

        public override string ShowMyIdentity()
        {
            return "Jeg er en elev.";
        }
    }

}
