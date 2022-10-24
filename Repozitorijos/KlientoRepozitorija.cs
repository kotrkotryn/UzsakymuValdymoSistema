using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uzsakymu_valdymo_sistema.Uzsakymai;

namespace Uzsakymu_valdymo_sistema.Repozitorijos
{
    internal class KlientoRepozitorija
    {
        List<KlientoUzsakymas> Klientas { get; set; }

        public KlientoRepozitorija()
        {
            Klientas = new List<KlientoUzsakymas>();
            Klientas.Add(new KlientoUzsakymas(110, 1, "Renkasi Menu", false));
            Klientas.Add(new KlientoUzsakymas(109, 2, "Baigtas", true));
            Klientas.Add(new KlientoUzsakymas(108, 3, "Laukia pristatymo", false));
            Klientas.Add(new KlientoUzsakymas(107, 4, "Laukia pristatymo", false));
            Klientas.Add(new KlientoUzsakymas(106, 5, "Baigtas", true));
            Klientas.Add(new KlientoUzsakymas(105, 6, "Laukia sąskaitos", false));
            Klientas.Add(new KlientoUzsakymas(104, 7, "Renkasi Menu", false));
            Klientas.Add(new KlientoUzsakymas(103, 8, "Renkasi Menu", false));
            Klientas.Add(new KlientoUzsakymas(102, 9, "Laukia pristatymo", false));
            Klientas.Add(new KlientoUzsakymas(101, 10, "Renkasi Menu", false));
        }
        public List<KlientoUzsakymas> Retrieve()
        {
            return Klientas;
        }
        public KlientoUzsakymas Retrieve(int klientoUzsakymasId)
        {
            return Klientas.Where(c => c.Id == klientoUzsakymasId).FirstOrDefault();
        }

        /*public bool UnitTest()
        {
            var isValid = true;

            if Id isValid = false;
            if (int.IsNullOrWhiteSpace(Stalas)) isValid = false;

            return isValid;
        }
        public void UnitTest()
        {
            //--Arrange
            var klientoUzsakymas = new KlientoUzsakymas();
            {
                Id = 110,
                Stalas = 1,
            };
            var expected = true;

            //Act
            var actual = klientoUzsakymas.Stalas;

            //--Assert
            Assert.AreEqual(expected, actual);
        }*/
    }
}
