using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uzsakymu_valdymo_sistema.Repozitorijos;
using Uzsakymu_valdymo_sistema.Uzsakymai;

namespace Uzsakymu_valdymo_sistema.Servisas
{
    internal class NeapmoketuUzsakymuAtaskaita
    {
        KlientoRepozitorija _klientoRepozitorija;
        VirtuvesRepozitorija _virtuvesRepozitorija;

        public NeapmoketuUzsakymuAtaskaita(KlientoRepozitorija klientoRepozitorija, VirtuvesRepozitorija virtuvesRepozitorija)
        {
            _klientoRepozitorija = klientoRepozitorija;
            _virtuvesRepozitorija = virtuvesRepozitorija;
        }

        public List<Ataskaita> SugeneruokNeapmoketuUzsakymuAtaskaita()
        {
            var listApmokejimasKlientai = _klientoRepozitorija.Retrieve();
            var listNeapmoketiUzsakymai = new List<KlientoUzsakymas>();

            Console.WriteLine("-----------------------");
            Console.WriteLine("UŽIMTI STALIUKAI");
            Console.WriteLine("-----------------------");

            foreach (var apmokejimas in listApmokejimasKlientai)
            {
                KlientoUzsakymas atsiskaitymasApmokejimoBusena = _klientoRepozitorija.Retrieve(apmokejimas.Id);
                if (!atsiskaitymasApmokejimoBusena.Apmokejimas)
                {
                    Console.WriteLine($"Nr.: {_klientoRepozitorija.Retrieve(apmokejimas.Id).Stalas} - Aptarnaujama");
                }
                
            }
            
            List<Ataskaita> neapmoketiUzsakymai = new List<Ataskaita>();
            foreach (var uzsakymas in listNeapmoketiUzsakymai)
            {
                Ataskaita apmokejimas = new Ataskaita();
                apmokejimas.KlientoStalas = uzsakymas.Stalas;
                apmokejimas.KlientoUzsakymoBusena = uzsakymas.Busena;
                apmokejimas.VirtuvesProcesas = _virtuvesRepozitorija.Retrieve(uzsakymas.Id).Procesas;
                apmokejimas.ApmokejimoBusena = uzsakymas.Apmokejimas;


                neapmoketiUzsakymai.Add(apmokejimas);
            }
            return neapmoketiUzsakymai;
        }
    }
}
