using System;
using Uzsakymu_valdymo_sistema.Repozitorijos;
using Uzsakymu_valdymo_sistema.Uzsakymai;

namespace Uzsakymu_valdymo_sistema.Servisas
{
    internal class Program
{
    static void Main(string[] args)
    {
            KlientoRepozitorija klientoRepozitorija = new KlientoRepozitorija();
            VirtuvesRepozitorija virtuvesRepozitorija = new VirtuvesRepozitorija();


            VisuKlientuAtaskaita visuKlientuAtaskaita = new VisuKlientuAtaskaita(klientoRepozitorija, virtuvesRepozitorija);
            NeapmoketuUzsakymuAtaskaita neapmoketuUzsakymuAtaskaita = new NeapmoketuUzsakymuAtaskaita(klientoRepozitorija, virtuvesRepozitorija);


            var bendraAtaskaita = visuKlientuAtaskaita.SugeneruokVisuKlientuAtaskaita();

            Console.WriteLine("-----------------------");
            Console.WriteLine("VISŲ KLIENTŲ ATASKAITA");
            Console.WriteLine("-----------------------");

            foreach (var ataskaita in bendraAtaskaita)
            {
                Console.WriteLine($"Kliento ID : {ataskaita.KlientoId}");
                Console.WriteLine($"Kliento stalo Nr. : {ataskaita.KlientoStalas}");
                Console.WriteLine($"Kliento užsakymo būsena: {ataskaita.KlientoUzsakymoBusena}");
                Console.WriteLine($"Virtuvės procesas: {ataskaita.VirtuvesProcesas}");
                Console.WriteLine($"Patiekalas : {ataskaita.Maistas}");
                Console.WriteLine($"Kiekis : {ataskaita.MaistoKiekis}");
                Console.WriteLine($"Gėrimas : {ataskaita.Gerimai}");
                Console.WriteLine($"Kiekis : {ataskaita.GerimuKiekis}");
                string apmok = ((ataskaita.ApmokejimoBusena) ? "Apmokėta" : "Laukiama apmokėjimo");
                Console.WriteLine($"Apmokėjimo būsena : {apmok}");
                Console.WriteLine("------------------------------------");
            }

            var neapmoketiUzsakymai = neapmoketuUzsakymuAtaskaita.SugeneruokNeapmoketuUzsakymuAtaskaita();

            Console.WriteLine("-----------------------");
            Console.WriteLine("NEAPMOKĖTŲ UŽSAKYMŲ ATASKAITA");
            Console.WriteLine("-----------------------");

            foreach (var apmokejimas in neapmoketiUzsakymai)
            {
                Console.WriteLine($"Kliento stalo Nr : {apmokejimas.KlientoStalas}");
                Console.WriteLine($"Kliento užsakymo būsena : {apmokejimas.KlientoUzsakymoBusena}");
                Console.WriteLine($"Virtuvės procesas : {apmokejimas.VirtuvesProcesas}");
                Console.WriteLine($"Apmokėjimo būsena: {apmokejimas.ApmokejimoBusena}"); //sutvarkyt, kad išvestų tik false kaip laukiama apmokejimo
                Console.WriteLine("------------------------------------");
            }
        }
}
}
