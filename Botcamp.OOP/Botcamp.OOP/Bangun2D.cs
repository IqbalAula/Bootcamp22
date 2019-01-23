using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botcamp.OOP
{
    abstract class Bangun2D
    {
        public abstract double HitungLuas();

        public void CetakLuas(String namabangun)
        {
            Console.WriteLine("Luas " + namabangun + "\t = " + HitungLuas());
        }

    }
}
