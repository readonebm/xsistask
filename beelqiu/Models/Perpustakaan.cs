using System;
namespace beelqiu.Models
{
    public class Perpustakaan
    {
        public string namaBuku;
        public int durasiPinjam;
        public int pinjam;
        public int denda;

        public Perpustakaan(string nb, int dp, int pj)
        {
            namaBuku = nb;
            durasiPinjam = dp;
            pinjam = pj;

            //switch (namaBuku)
            //{
            //    case "A":
            //        durasiPinjam = 14;
            //        break;
            //    case "B":
            //        durasiPinjam = 3;
            //        break;
            //    case "C":
            //        durasiPinjam = 7;
            //        break;
            //    case "D":
            //        durasiPinjam = 7;
            //        break;
            //}


            if(pinjam > durasiPinjam)
            {
                denda = 100 * (pinjam - durasiPinjam);
            }
            else
            {
                denda = 0;
            }

        }
    }
}
