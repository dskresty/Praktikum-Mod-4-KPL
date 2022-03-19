using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302200012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hasil Penjumlahan 3 angka: " + Penjumlahan.JumlahTigaAngka<float>(13f, 02f, 20f));

            Console.WriteLine("\n");

        }

        class Penjumlahan
        {
            public static T JumlahTigaAngka<T>(T satu, T dua, T tiga)
            {
                dynamic A = satu;
                dynamic B = dua;
                dynamic C = tiga;
                //Console.WriteLine(satu + "" + dua + ""  + tiga);
                return A + B + C;
            }
        }
    }
}