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
            soalDelapanBelas();
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
            float biayaParkir = 0;

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

        static void soalDelapan()
        {
            int[] deret = {1,2,4,7,8,6,9};
            Array.Sort(deret);

            int nilaiMIN = 0;
            int nilaiMax = 0;
            int hitung = 0;

            for (int i = 0; i < deret.Length; i++)
            {
                if (i < 4)
                {
                    nilaiMIN += deret[i];
                }
            }

            for (int i = deret.Length - 1; i >= 0; i--)
            {

                if (hitung == 4)
                {
                    break;
                }
                else
                {
                    nilaiMax += deret[i];
                }
                hitung++;
            }

            Console.WriteLine($"Nilai MIN: {nilaiMIN}");
            Console.WriteLine($"Nilai MAX: {nilaiMax}");
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

        static void soalTigaBelas()
        {
            /*
             Jam berkaitan dengan lingkaran. satu lingkaran ada 360 derajat.
             berarti kalo dari jam 00.00 s.d 12.00 berarti ada 360 derajat.
             - harus mencari sudut jam.
               > sudut dalam 1 jam, 360 / 12 jam = 30 derajat/ jam.
             - harus mencari sudut menit.
               > sudut dalam 1 menit, 360/60 menit = 6 derajat / menit.
            */

            string input = "2:20";
            DateTime inputDate = DateTime.ParseExact(input, "h:m", CultureInfo.InvariantCulture);

            int jam = Convert.ToInt32(inputDate.Hour.ToString());
            int menit = Convert.ToInt32(inputDate.Minute.ToString());

            double sudutJam = (jam * 30) + (menit * 30.0 / 60);
            double sudutMenit = menit * 6;

            double suduts = Math.Abs(sudutJam-sudutMenit);

            if (suduts > 180)
            {
                suduts = 360 - suduts;
            }

            Console.Write($"Sudut yang terbentuk adalah {suduts} derajat.");
        }

        static void soalEmpatBelas()
        {
            /*
             N = 3 > 7 1 2 4 3 9 0
             N = 1 > 9 0 7 1 2 4 1 
            */

            string input = "3907124";
            var deret = input.ToCharArray();

            int n = 1;
            int y = 0;

            while (y < n)
            {
                var angkaPertama = deret[0];
                for (int i = 0; i < deret.Length-1; i++)
                {
                    deret[i] = deret[i + 1];   
                }
                deret[deret.Length - 1] = angkaPertama;

                y++;
            }
            

            foreach (var item in deret)
            {
            Console.Write(item + ",");
            }

        }

        static void soalLimaBelas()
        {
            string input = "03:40:44 PM";
            var waktu = Convert.ToDateTime(input);

            Console.Write(waktu.ToString("HH:mm:ss"));
        }

        static void soalEnamBelas()
        {
            float[] haFood = {42,50,30,70,30};
            List<float> haFoodPS = new List<float>() { };
            int n = 4;

            float pajak = 0;
            float haFoods = 0;

            foreach (var item in haFood)
            {
                pajak = item * (0.15f);
                haFoods = item + pajak;
                haFoodPS.Add(haFoods);
            }

            float bayarperOrg = 0;
            List<float> bayarperOrgs = new List<float>() { };

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < haFoodPS.Count; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        continue;

                    }else if(j==0)
                    {
                        bayarperOrg += haFoodPS[j] / 3;
                    }
                    else
                    {
                        bayarperOrg += haFoodPS[j] / 4;
                    }

                }
                bayarperOrgs.Add(bayarperOrg);
                bayarperOrg = 0;
            }

            //Orang ke 1 adalah yang punya alergi
            for (int j = 0; j < bayarperOrgs.Count; j++)
            {
                Console.WriteLine($"Orang ke{j+1} bayar {bayarperOrgs[j]}K");
            }
             
        }

        static void soalTujuhBelas()
        {
            char[] jalur = {'N','N','T','N','N','N','T','T','T','T','T','N','T','T','T','N','T','N'};

            int kondisiJalur = 0;
            int gunung = 0;
            int lembah = 0;

            for (int i = 0; i < jalur.Length; i++)
            {
                if (jalur[i] == 'N')
                {
                    kondisiJalur++;
                    if (kondisiJalur == 0)
                    {
                        lembah++;
                    }
                }
                else
                {
                    kondisiJalur--;
                    if (kondisiJalur == 0)
                    {
                        gunung++;
                    }
                }

            }

            Console.Write($"Hattori sudah melewati {gunung} gunung dan {lembah} lembah.");
        }

        static void soalDelapanBelas()
        {
           char[] pangram = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'p', 'w', 'x', 'y', 'z' };

            string kalimat = "Sphinx of black quartz, judge my vow";
            //string kalimat = "Brawny gods just flocked up to quiz and vex him";
            //string kalimat = "Check back tomorrow; I will see if the book has arrived";
            //string kalimat = "The quick brown fox jumps over the lazy dog";

            string isPangram = "Kalimat Pangram";

            string kaltemp = kalimat.ToLower();

            for (int i = 0; i < pangram.Length; i++)
            {
                if (kaltemp.Contains(pangram[i]))
                {
                    continue;
                }
                else
                {
                    isPangram = "Bukan kalimat pangram";
                }
            }
            Console.Write(isPangram);

        }
    }
}
