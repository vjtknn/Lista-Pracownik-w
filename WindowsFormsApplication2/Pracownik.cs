using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Pracownik
    {
       
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public int ID { get; set; }
        public int LDL { get; set; }

        public Pracownik(string imie, string nazwisko, int ID, int LDL)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.ID = ID;
            this.LDL = LDL;

        }

    }
}
