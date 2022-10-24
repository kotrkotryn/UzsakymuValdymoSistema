using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uzsakymu_valdymo_sistema.Uzsakymai;

namespace Uzsakymu_valdymo_sistema.Repozitorijos
{
    internal class VirtuvesRepozitorija
    {
        List<VirtuvesUzsakymas> Virtuve { get; set; }

        public VirtuvesRepozitorija()
        {
            Virtuve = new List<VirtuvesUzsakymas>();
            Virtuve.Add(new VirtuvesUzsakymas(110, "BigTasty", 1, "Cola", 1, "Virtuvė laukia"));
            Virtuve.Add(new VirtuvesUzsakymas(109, "BigTasty", 2, "Sprite", 1, "Pagaminta"));
            Virtuve.Add(new VirtuvesUzsakymas(108, "BigMac", 1, "Fanta", 1, "Gaminama"));
            Virtuve.Add(new VirtuvesUzsakymas(107, "BigMac", 1, "Coffee", 1, "Gaminama"));
            Virtuve.Add(new VirtuvesUzsakymas(106, "CheeseBurger", 4, "Cola", 2, "Pagaminta"));
            Virtuve.Add(new VirtuvesUzsakymas(105, "CheeseBurger", 3, "Sprite", 1, "Pagaminta"));
            Virtuve.Add(new VirtuvesUzsakymas(104, "Maestro", 2, "Coffee", 2, "Virtuvė laukia"));
            Virtuve.Add(new VirtuvesUzsakymas(103, "FilletOFish", 1, "OrangeJuice", 1, "Virtuvė laukia"));
            Virtuve.Add(new VirtuvesUzsakymas(102, "Salad", 4, "AppleJuice", 4, "Gaminama"));
            Virtuve.Add(new VirtuvesUzsakymas(101, "Salad", 1, "Coffee", 1, "Virtuvė laukia"));
        }
        public List<VirtuvesUzsakymas> Retrieve()
        {
            return Virtuve;
        }
        public VirtuvesUzsakymas Retrieve(int virtuvesUzsakymasId)
        {
            return Virtuve.Where(c => c.Id == virtuvesUzsakymasId).FirstOrDefault();
        }
    }
}
