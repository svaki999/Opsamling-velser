using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpsamlingØvelser.Køretøjer
{
    internal class Audi : Bil
    {
        public Audi(string model, int bagagerumVolume)
        : base("Audi", model, bagagerumVolume)
        { }
    }
}
