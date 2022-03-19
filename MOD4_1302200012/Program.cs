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
            SimpleDataBase<float> simpleData = new SimpleDataBase<float>();
            simpleData.AddNewData(13f);
            simpleData.AddNewData(02f);
            simpleData.AddNewData(20f);


            simpleData.PrintData();

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
        class SimpleDataBase<T>
        {
            private List<T> storedData;
            private List<DateTime> inputDates;
            public SimpleDataBase()
            {
                this.storedData = new List<T>();
                inputDates = new List<DateTime>();
            }

            public void AddNewData(T x)
            {
                storedData.Add(x);
                inputDates.Add(DateTime.Now);
            }

            public void PrintData()
            {
                int panjang = storedData.Count;
                for (int i = 0; i < panjang; i++)
                {
                    Console.WriteLine("Data " + (i + 1) + " berisi : " + storedData[i] + ", yang disimpan pada waktu UTC: " + inputDates[i]);
                }

            }
        }
    }
}