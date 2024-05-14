using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NawaDataFinal
{
    class MainMenu
    {
        public static void Menu()
        {
            bool status = true;
            while (status)
            {
                try
                {
                    Console.WriteLine("0. Exit");
                    Console.WriteLine("1. Hitung Jumlah Kata Pada Kalimat");
                    Console.WriteLine("2. Cari Angka Terbesar Array");
                    Console.WriteLine("3. Urut Angka Pada Array");
                    Console.WriteLine("4. Cari Huruf Yang Paling Sering Muncul");
                    Console.Write("Ketik Pilihan Anda  ( 0 - 4 ) : ");
                    string choice = Console.ReadLine();
                    switch(choice)
                    {
                        case "0":
                            Console.WriteLine("Exit ...");
                            status = false;
                            break;
                        case "1":
                            Console.WriteLine("\n Hitung Jumlah Kata Pada Kalimat");
                            Solutions.HitungJumlahKata();
                            break;
                        case "2":
                            Console.WriteLine("\n Cari Angka Terbesar Pada Array");
                            Solutions.CariAngkaTerbesar();
                            break;
                        case "3":
                            Console.WriteLine("\n Urut Angka Pada Array");
                            Solutions.SortArray();
                            break;
                        case "4":
                            Console.WriteLine("\n Cari Huruf Yang Paling Sering Muncul");
                            Solutions.HurufSeringMuncul();
                            break;
                        default:
                            Console.WriteLine("\n ### Invalid Input ### \n ");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
