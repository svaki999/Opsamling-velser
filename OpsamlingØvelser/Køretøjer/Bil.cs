using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpsamlingØvelser.Køretøjer
{
    // C# tillader ikke direkte arv fra flere base klasser for at undgå potentielle konflikter,
    // men det støtter i stedet flerarv gennem brug af grænseflader (interfaces).
    internal class Bil : Køretøj//, FireHjulKøretøj
    {
        public int BagagerumVolumeKubikCm { get; }

        public Bil(string mærke, string model, int bagagerumVolume)
        : base(mærke, model)
        {
            BagagerumVolumeKubikCm = bagagerumVolume;
        }

        
    }
}
