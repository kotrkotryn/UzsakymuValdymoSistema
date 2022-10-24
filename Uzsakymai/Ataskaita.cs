using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzsakymu_valdymo_sistema.Uzsakymai
{
    internal class Ataskaita
    {
        public int KlientoId { get; set; }
        public int KlientoStalas { get; set; }
        public string KlientoUzsakymoBusena { get; set; }
        public string VirtuvesProcesas { get; set; }
        public string Maistas { get; set; }
        public int MaistoKiekis { get; set; }
        public string Gerimai { get; set; }
        public int GerimuKiekis { get; set; }
        public bool ApmokejimoBusena { get; set; }


    }
}
