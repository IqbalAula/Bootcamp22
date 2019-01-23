using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botcamp.OOP
{
    class Segitiga : Bangun2D
    {
        private double alas;
        private double tinggi;

        public Segitiga(double a, double t)
        {
            this.alas = a;
            this.tinggi = t;
        }


        public override double HitungLuas()
        {
            return (0.5 * alas * tinggi);
        }
    }
}
