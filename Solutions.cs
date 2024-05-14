using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NawaDataFinal
{
    class Solutions
    {
        public static void HitungJumlahKata()
        {
            try
            {
                //Input Dari Code Variable
                string kalimat = "Halo, nama saya John Doe";
                Console.WriteLine($"Kalimat Pada Code : {kalimat}");

                string[] kata = kalimat.Split(" ");
                Console.WriteLine($"Jumlah Kata Yang Ada Di Variable Adalah: {kata.Length} \n");

                //Pakai Input Dari Console
                Console.WriteLine("Input Kalimat");
                string[] input = Console.ReadLine().Split(" ");

                Console.WriteLine($"Jumlah Kata Yang Diinput : {input.Length} \n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void CariAngkaTerbesar()
        {
            try
            {
                int max = 0;

                //Input Dari Code Variable
                int[] array = new int[] { 3, 1, 5, 2, 4 };
                Console.WriteLine("Angka Pada Array di Code adalah :");
                foreach (int a in array)
                {
                    if (a > max)
                    {
                        max = a;
                    }
                    Console.Write($"{a} ");
                }
                Console.WriteLine();
                Console.WriteLine($"\nAngka Terbesar Pada Array Tersebut Adalah : {max} \n");

                // Penggunaan Ulang Variable Yang Sebelumnya sudah ada
                max = 0;

                //Pakai Input Dari Console
                Console.WriteLine("Input Angka (gunakan spasi) contoh : 7 8 3 6 99 10");
                string[] input = Console.ReadLine().Split(" ");

                int[] angka = new int[input.Length];
                for(int i = 0; i < angka.Length; i++)
                {
                    angka[i] = int.Parse(input[i]);

                    if (angka[i] > max)
                    {
                        max = angka[i];
                    }
                }

                Console.WriteLine($"Angka Terbesar Pada Array Tersebut Adalah {max} \n");

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void SortArray()
        {
            try
            {
                //Input Dari Code Variable
                int[] array = new int[] {3,1,5,2,4};
                Console.WriteLine("Array Pada Variable Di Code adalah : ");
                foreach(int a in array)
                {
                    Console.Write($"{a} ");
                }
                Console.WriteLine();

                Array.Sort(array);

                Console.WriteLine("\n Array Setelah Diurutkan :");
                foreach (int a in array)
                {
                    Console.Write($"{a} ");
                }
                Console.WriteLine();

                //Input Dari Console
                Console.WriteLine("Input Angka (gunakan spasi) contoh : 11 31 32 17 7 9");
                string[] input = Console.ReadLine().Split(" ");

                int[] newInput = new int[input.Length];
                for(int i = 0; i < newInput.Length; i++)
                {
                    newInput[i] = int.Parse(input[i]);
                }

                //Bubble Sort
                for(int i = 0;  i < newInput.Length; i++)
                {
                    for(int j = 0; j < newInput.Length; j++)
                    {
                        if (newInput[j] > newInput[i])
                        {
                            int temp = newInput[i];
                            newInput[i] = newInput[j];
                            newInput[j] = temp;
                        }
                    }
                }

                Console.WriteLine("\n Array Setelah Diurutkan :");
                foreach (int n in newInput)
                {
                    Console.Write($"{n} ");
                }
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void HurufSeringMuncul()
        {
            try
            {
                //Input Dari Code Variable
                string kata = "hello";
                Console.WriteLine($"Kata Yang Ada Pada Code Adalah : {kata}");
                
                //Penggunaan StringBuilder Untuk Mempermudah Manipulasi Kata
                StringBuilder sb = new StringBuilder();
                int counter = 0;
                int max = 0;


                Dictionary<char, int> frekuensi = new Dictionary<char, int>();
                foreach (char k in kata)
                {
                    if (!frekuensi.ContainsKey(k))
                    {
                        counter = 1;
                        frekuensi.Add(k, counter);
                    }
                    else if (frekuensi.ContainsKey(k))
                    {
                        //Ambil Counter Dari Value Dictionary Frekuensi
                        counter = frekuensi[k];
                        //Update Value dari Key Frekuensi
                        frekuensi[k] = counter + 1;
                    }
                }
                // Iterasi Untuk Manipulasi Element Pada Dictionary
                foreach (KeyValuePair<char, int> f in frekuensi)
                {
                    if (f.Value > max)
                    {
                        max = f.Value;
                        sb.Clear();
                        sb.Append(f.Key);
                    }
                    if( f.Value == max)
                    {
                        //Agar Tidak Terjadi Duplikasi Character/Huruf Yang Sama
                        if (!sb.ToString().Contains(f.Key))
                        {
                            sb.Append(f.Key);
                        }
                    }
                }
                Console.Write("Kata Yang Sering Muncul Adalah: ");

                if (sb.ToString().Length > 1)
                {
                    foreach (char s in sb.ToString())
                    {
                        Console.Write($"{s}, ");
                    }
                }
                else
                {
                    Console.WriteLine(sb.ToString());
                }
                Console.WriteLine();
                
                // Penggunaan Ulang Variable Yang Sebelumnya sudah ada
                sb.Clear();
                counter = 0;
                max = 0;
                frekuensi.Clear();

                //Input Dari Console
                Console.WriteLine("\n Ketik Kata : ");

                string input = Console.ReadLine();
                if(input.Length > 15)
                {
                    Console.WriteLine("### Kata Terlalu Panjang, Maksimal 15 huruf ### \n ");
                }
                else
                {
                    foreach(char i in input)
                    {
                        if (!frekuensi.ContainsKey(i))
                        {
                            counter = 1;
                            frekuensi.Add(i, counter);
                        }
                        else if (frekuensi.ContainsKey(i))
                        {
                            counter = frekuensi[i];
                            frekuensi[i] = counter + 1;
                        }
                    }

                    foreach(KeyValuePair<char, int> f in frekuensi)
                    {
                        if(f.Value > max)
                        {
                            max = f.Value;
                            sb.Clear();
                            sb.Append(f.Key);
                        }
                        if (f.Value == max)
                        {
                            if (!sb.ToString().Contains(f.Key))
                            {
                                sb.Append(f.Key);
                            }
                        }
                    }
                }
                Console.Write("Kata Yang Sering Muncul Adalah: ");

                if (sb.ToString().Length > 1)
                {
                    foreach (char s in sb.ToString())
                    {
                        Console.Write($"{s}, ");
                    }
                }
                else
                {
                    Console.WriteLine(sb.ToString());
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
