using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botcamp.OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Bangun2D panggil;
            Console.WriteLine("=========== Perhitungan Luas ===========");
            Console.WriteLine("1. Lingkaran");
            Console.WriteLine("2. Segitiga");
            Console.WriteLine("3. Persegi");
            Console.WriteLine("4. Persegi Panjang");
            Console.WriteLine("========================================");
            Console.Write("Masukkan Pilihanmu : ");

            int pil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("========================================");
            switch (pil)
            {
                case 1:
                    Console.WriteLine("\tMenghitung Lingkaran");
                    Console.Write("Masukkan Jari - jari : ");
                    double jari = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("========================================");
                    panggil = new Lingkaran(jari);
                    panggil.CetakLuas("Lingkaran");
                    Console.Read();
                    break;
                case 2:
                    Console.WriteLine("\tMenghitung Segitiga");
                    Console.Write("Masukkan Tinggi : ");
                    double tinggi = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukkan Alas : ");
                    double alas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("========================================");
                    panggil = new Segitiga(alas, tinggi);
                    panggil.CetakLuas("Segitiga");
                    Console.Read();
                    break;
                case 3:
                    Console.WriteLine("\tMenghitung Persegi");
                    Console.Write("Masukkan Sisi : ");
                    double sisi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("========================================");
                    panggil = new Persegi(sisi);
                    panggil.CetakLuas("Persegi");
                    Console.Read();
                    break;
                case 4:
                    Console.WriteLine("\tMenghitung Persegi Panjang");
                    Console.Write("Masukkan Panjang : ");
                    double panjang = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukkan Lebar : ");
                    double lebar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("========================================");
                    panggil = new PersegiPanjang(panjang, lebar);
                    panggil.CetakLuas("Persegi Panjang");
                    Console.Read();
                    break;
                default:
                    Console.WriteLine("Your choice is not found, try again see you later good bye!!!");
                    break;
            }
            Console.Read();
        }
    }
}
