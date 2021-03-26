using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozoProjekt
{
    class Dolgozo
    {
        private string vezeteknev;
        private string keresztnev;
        private string nem;
        private int eletkor;
        private int fizetes;
        private string ft;

        public Dolgozo(string vezeteknev, string keresztnev, string nem, int eletkor, int fizetes, string ft)
        {
            this.vezeteknev = vezeteknev;
            this.keresztnev = keresztnev;
            this.nem = nem;
            this.eletkor = eletkor;
            this.fizetes = fizetes;
            this.ft = ft;
        }

        public string Vezeteknev { get => vezeteknev; set => vezeteknev = value; }
        public string Keresztnev { get => keresztnev; set => keresztnev = value; }
        public string Nem { get => nem; set => nem = value; }
        public int Eletkor { get => eletkor; set => eletkor = value; }
        public int Fizetes { get => fizetes; set => fizetes = value; }
        public string Ft { get => ft; set => ft = value; }

        public override string ToString()
        {
            return String.Format("{0} {1} - {2} - {3} - {4} {5}", vezeteknev, keresztnev, nem, eletkor, fizetes, ft);
        }
    }
}
