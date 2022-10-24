using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uzsakymu_valdymo_sistema.Repozitorijos;
using Uzsakymu_valdymo_sistema.Uzsakymai;

namespace Uzsakymu_valdymo_sistema.Servisas
{
    internal class VisuKlientuAtaskaita
    {
        KlientoRepozitorija _klientoRepozitorija;
        VirtuvesRepozitorija _virtuvesRepozitorija;

        public VisuKlientuAtaskaita(KlientoRepozitorija klientoRepozitorija, VirtuvesRepozitorija virtuvesRepozitorija)
        {
            _klientoRepozitorija = klientoRepozitorija;
            _virtuvesRepozitorija = virtuvesRepozitorija;
        }

        public List<Ataskaita> SugeneruokVisuKlientuAtaskaita()    //metodas su ataskaitom
        {
            var listApmokejimasKlientai = _klientoRepozitorija.Retrieve();
            var listVisiKlientai = new List<KlientoUzsakymas>();

            Console.WriteLine("-----------------------");
            Console.WriteLine("VISI STALIUKAI");
            Console.WriteLine("-----------------------");

            foreach (var apmokejimas in listApmokejimasKlientai)
            {
                KlientoUzsakymas klientoUzsakymasApmokejimas = _klientoRepozitorija.Retrieve(apmokejimas.Id);
                if (klientoUzsakymasApmokejimas.Apmokejimas)
                {
                    listVisiKlientai.Add(apmokejimas);
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Nr.: {_klientoRepozitorija.Retrieve(apmokejimas.Id).Stalas} - Apmokėta");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else
                { 
                    if (!klientoUzsakymasApmokejimas.Apmokejimas)
                    {
                        listVisiKlientai.Add(apmokejimas);
                        Console.BackgroundColor = ConsoleColor.DarkBlue; 
                        Console.WriteLine($"Nr.: {_klientoRepozitorija.Retrieve(apmokejimas.Id).Stalas} - Užimtas");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                }
            }

            List<Ataskaita> bendraAtaskaita = new List<Ataskaita>();
            foreach(var uzsakymas in listVisiKlientai)
            {
                Ataskaita ataskaita = new Ataskaita();
                ataskaita.KlientoId = uzsakymas.Id;
                ataskaita.KlientoStalas = uzsakymas.Stalas;
                ataskaita.KlientoUzsakymoBusena = uzsakymas.Busena;
                ataskaita.VirtuvesProcesas = _virtuvesRepozitorija.Retrieve(uzsakymas.Id).Procesas;
                ataskaita.Maistas = _virtuvesRepozitorija.Retrieve(uzsakymas.Id).Maistas;
                ataskaita.MaistoKiekis = _virtuvesRepozitorija.Retrieve(uzsakymas.Id).MaistasKiekis;
                ataskaita.Gerimai = _virtuvesRepozitorija.Retrieve(uzsakymas.Id).Gerimai;
                ataskaita.GerimuKiekis = _virtuvesRepozitorija.Retrieve(uzsakymas.Id).GerimaiKiekis;
                ataskaita.ApmokejimoBusena = uzsakymas.Apmokejimas;


                bendraAtaskaita.Add(ataskaita);
            }
            return bendraAtaskaita;
        }
    }
}
