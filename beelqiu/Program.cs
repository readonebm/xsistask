using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using beelqiu.Models;

namespace beelqiu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Banu!");
            soalTujuh();
        }

        static void soalSatu()
        {

            List<int[]> listBarang = new List<int[]>();

            int[] kacaMata = { 500, 600, 700, 800 };

            int[] Baju = { 200, 400, 350 };

            int[] Sepatu = { 400, 350, 200, 300 };

            int[] Buku = { 100, 50, 150 };


            listBarang.Add(kacaMata);
            listBarang.Add(Baju);
            listBarang.Add(Sepatu);
            listBarang.Add(Buku);

            int[] barangdiBeli = new int[4];

            int uang = 1000;
            int sisaUang = uang;
            int countBarang = 0;


            for (int i = 0; i < listBarang.Count; i++)
            {
                for (int j = 0; j < listBarang[i].Length; j++)
                {
                    if (sisaUang >= listBarang[i][j])
                    {
                        sisaUang -= listBarang[i][j];
                        countBarang++;
                        barangdiBeli[i] = listBarang[i][j];
                        break;
                    }
                    
                } 
            }

            Console.WriteLine($"Jumlah uang yang dipakai: {uang - sisaUang}");
            Console.WriteLine($"Jumlah item yang bisa dibeli: {countBarang}\n(Kacamata {barangdiBeli[0]}; Baju {barangdiBeli[1]}; Sepatu {barangdiBeli[2]}; Buku {barangdiBeli[3]})");

            
        }

        static void soalDua()
        {
            //kondisi 1 : 28 Februari 2016 – 7 Maret 2016        

            //kondisi 2 : 29 April 2018 – 30 Mei 2018

            Console.Write("Masukan tanggal pinjam dan pengembalian dengan format tahun/bulan/tanggal.\n(Contoh: 2016/2/28)");
            Console.WriteLine();
            Console.WriteLine("---------------");
            Console.Write("Mulai Pinjam: ");
            string input1 = Console.ReadLine();
            var date1 = DateTime.Parse(input1);
            Console.Write("Rencana Pengembalian: ");
            string input2 = Console.ReadLine();
            var date2 = DateTime.Parse(input2);

            TimeSpan ts = date2 - date1;
            int pinjam = (int)ts.TotalDays;


            List<Perpustakaan> listBuku = new List<Perpustakaan>()
            {
                new Perpustakaan("A",14,pinjam),
                new Perpustakaan("B",3,pinjam),
                new Perpustakaan("C",7,pinjam),
                new Perpustakaan("D",7,pinjam)
            };

            Console.WriteLine("---------------");

            foreach (var item in listBuku)
            {
            Console.WriteLine($"Buku {item.namaBuku}, denda {item.denda}.");
            }
        }

        static void soalTiga()
        {
            string masuk = "2019/1/27 05:00:01";
            string keluar = "2019/1/27 17:45:03";

            var dateMasuk = DateTime.Parse(masuk);
            var dateKeluar = DateTime.Parse(keluar);

            //-----------------------------------------//

            TimeSpan lamaParkir = dateKeluar-dateMasuk;
            string x = lamaParkir.ToString("T");
            var y = DateTime.Parse(x);
            double biayaParkir = 0;

            //-----------------------------------------//

            if (y.Hour <= 8)
            {
                biayaParkir = 1000 * y.Hour;
                //Console.Write("Masuk parkir per Jam");
            }
            else if (y.Hour >= 8 && y.Minute >= 0 && y.Second > 0 && y.Hour <= 24)
            {
                biayaParkir = 8000;
                //Console.Write("Masuk parkir per hari");
            }
            else if (y.Hour >= 24 && y.Minute >= 00 && y.Second > 00 && y.Hour <= 32)
            {
                biayaParkir = 15000 + ((y.Hour - 24) * 1000);
            }
            Console.Write(biayaParkir);
        }

        static void soalEmpat()
        {
            Console.Write("Masukan nilai n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            List<int> result = new List<int>();
            bool isPrimeNumber = true;

            for (int i = 2; i < n; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i%j == 0)
                    {
                    isPrimeNumber = false;
                    break;
                    }
                }

                if (isPrimeNumber)
                {
                result.Add(i);
                }
            }

            Console.Write(result[0]);
        }

        static void soalLima()
        {
            //Bilangan prima : 1, 1, 2, 3, 5, 8, 13, 21, 34, 55,...
            Console.Write("Masukan nilai n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int num1 = 0;
            int num2 = 1;
            int Fibnum = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{Fibnum}, ");
                Fibnum = num1 + num2;
                num1 = num2;
                num2 = Fibnum;
            }
        }

        static void soalEnam()
        {
            //Palindrome
            string kata = "donat";

            var katas = kata.ToCharArray();

            bool isPalindrome = true;

            for (int i = 0; i < katas.Length; i++)
            {
                //Console.WriteLine($"{i} : {katas.Length - i - 1}");
                if (katas[i] != katas[katas.Length - i - 1])
                {
                    isPalindrome = false;
                }
            }
            
            Console.Write(isPalindrome);
        }

        static void soalTujuh()
        {
            string input = "8702717630713461643";
            //string input = "1444525526";

            var deret = input.ToCharArray();

            int[] x = Array.ConvertAll(deret, i => (int)char.GetNumericValue(i));
            Array.Sort(x);

            // Mean
            //int meanX = x.Sum() / x.Length;
            //Console.Write(meanX);

            // Median
            //var medianX = 0;
            //var y = x.Length / 2;

            //if (x.Length == 0)
            //{
            //    medianX = (x[y]+x[y+1])/2;
            //}
            //else
            //{
            //    medianX = x[y];
            //}
            //Console.Write(medianX);


            // Modus

            int count = 0;
            int hitMode = 0;
            int mode = 0;

            for (int i = 0; i < x[x.Length-1]; i++)
            {
                for (int j = 0; j < x.Length; j++)
                {
                    if (i == x[j])
                    {
                        count++;
                        if (count > hitMode)
                        {
                            hitMode = count;
                            mode = i;
                        }
                    }


                }
                count = 0;
            }
            Console.WriteLine($"Mode: {mode}");



            //with LINQ Method
            //var derGroup = x.GroupBy(i => i);
            //int maxCount = derGroup.Max(g => g.Count());
            //int mode = derGroup.First(g => g.Count() == maxCount).Key;

            //Console.Write(mode);

        }

        static void soalDelapan() //Belum paham sama soalnya
        {
            Console.Write("Soal Nomor Delapan");
        }

        static void soalSembilan()
        {
            int n = 5;

            int result = 0;

            for (int i = 0; i < n; i++)
            {
                result += n;
                Console.Write($"{result} ");
            }
        }

        static void soalSepuluh()
        {
            string kata = "Rani Tiara";

            var katas = kata.Split(" ");

            for (int i = 0; i < katas.Length; i++)
            {

                for (int j = 0; j < 5; j++)
                {
                    var hurufAkhir = katas[i][katas[i].Length - 1];
                    var hurufAwal = katas[i][0];

                    //Console.Write(hurufAwal);

                    //Console.Write(katas[i][hurufAkhir]);
                    if (j == 0)
                    {
                        Console.Write($"{hurufAwal}");
                    }else if(j==4){
                        Console.Write($"{hurufAkhir}");
                    }
                    else
                    {
                        Console.Write("*");
                    }

                }
                Console.Write(" ");
            }

            
        }

        static void soalSebelas()
        {
            string input = "Jeruk";

            var charInput = input.ToCharArray();

            var pemisah = charInput.Length % 2;
            var indexPemisah = charInput.Length / 2;

            for (int i = charInput.Length - 1; i >= 0; i--)
            {
                if (pemisah == 0)
                {
                    for (int j = charInput.Length - 1; j >= 0; j--)
                    {
                        if(j == indexPemisah - 1)
                        {
                        Console.Write($"{charInput[i]}");
                        }
                        Console.Write("*");
                    }
                }
                else
                {
                    for (int j = charInput.Length - 1; j > 0; j--)
                    {
                        if (j == indexPemisah)
                        {
                            Console.Write($"{charInput[i]}");
                        }
                        Console.Write("*");
                    }
                }


                Console.Write(" ");
      
            }
        }

        static void soalDuaBelas()
        {
            int[] input = new int[] {1,2,1,3,4,7,1,1,5,6,1,8};
            int index = 0;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i+1; j < input.Length; j++)
                {
                    if (input[i] > input[j])
                    {
                        index = input[j];
                        input[j] = input[i];
                        input[i] = index;
                    }

                }
                Console.Write($"{input[i]}, ");
            }
        }

        static void soalEmpatBelas()
        {
            string input = "3907124";
            var deret = input.ToCharArray();

            var angkaPertama = deret[0];
            var angkaAkhir = deret[deret.Length-1];
            int n = 3;

            for (int i = 0; i < deret.Length; i++)
            {
                //angkaPertama = deret[n];

                //if (i == 0)
                //{
                //    Console.Write($"{angkaPertama}");
                //}else if (i == deret.Length - 1)
                //{
                //    angkaAkhir = deret[n-1];
                //    Console.Write($"{angkaAkhir} ");
                //}
                //else
                //{
                //Console.Write($"{deret[i+1]}");
                //}

                if (i == 0)
                {
                    Console.Write(deret[n]);
                }else if (i > n)
                {
                    Console.Write(deret[n+1]);
                }
                else
                {
                    Console.Write("x");
                }
            }
            
        }

        static void soalLimaBelas()
        {
            DateTime waktu = DateTime.Now;

            Console.Write(waktu.ToString("HH:mm:ss"));
        }
    }
}
