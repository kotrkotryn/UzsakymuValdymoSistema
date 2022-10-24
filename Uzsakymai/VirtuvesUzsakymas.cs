using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzsakymu_valdymo_sistema.Uzsakymai
{
    internal class VirtuvesUzsakymas
    {
        public int Id { get; set; }
        public string Maistas { get; set; }
        public int MaistasKiekis { get; set; }
        public string Gerimai { get; set; }
        public int GerimaiKiekis { get; set; }
        public string Procesas { get; set; }

        public VirtuvesUzsakymas(int id, string maistas, int maistasKiekis, string gerimai, int gerimaiKiekis, string procesas)
        {
            Id = id;
            Maistas = maistas;
            MaistasKiekis = maistasKiekis;
            Gerimai = gerimai;
            GerimaiKiekis = gerimaiKiekis;
            Procesas = procesas;
        }
    }
}
