using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nobel_dij
{
    class Dij
    {
        //év;típus;keresztnév;vezetéknév
        int ev;
        string tipus;
        string knev;
        string vnev;

        public Dij (string sor)
        {
            string[] daraboltSor = sor.Split(';');
            Ev = Convert.ToInt32(daraboltSor[0]);
            Tipus = daraboltSor[1];
            Knev = daraboltSor[2];
            Vnev = daraboltSor[3];


        }

        public int Ev { get => ev; set => ev = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public string Knev { get => knev; set => knev = value; }
        public string Vnev { get => vnev; set => vnev = value; }
    }
}
