using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzsakymu_valdymo_sistema.Uzsakymai
{
    internal class KlientoUzsakymas
    {
        public int Id { get; set; }
        public int Stalas { get; set; }
        public string Busena { get; set; }
        public bool Apmokejimas { get; set; }

        public KlientoUzsakymas(int id, int stalas, string busena, bool apmokejimas)
        {
            Id = id;
            Stalas = stalas;
            Busena = busena;
            Apmokejimas = apmokejimas;
        }
    }
}
