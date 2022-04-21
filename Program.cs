using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemograman2861
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No Nik/Nama                   Gaji Bulanan");
            Console.WriteLine("------------------------------------------");
            Karyawan karyawan1 = new Karyawan(1, 190302123, "Syarif", 5000000);
            karyawan1.Cetak();
            Karyawan karyawan2 = new Karyawan(2, 190302124, "Nurwahid ", 4000000);
            karyawan2.Cetak();

            Console.WriteLine("");
            Console.WriteLine("Asyiiiiik Kenaikan Gaji 10%!!!");
            Console.WriteLine("");
            Console.WriteLine("No Nik/Nama                   Gaji Bulanan");
            Console.WriteLine("------------------------------------------");
            Karyawan Naik1 = new Karyawan(1, 190302123, "Syarif", 5000000);
            Naik1.CetakNaik();
            Karyawan Naik2 = new Karyawan(2, 190302124, "Nurwahid ", 4000000);
            Naik2.CetakNaik();
            Console.ReadKey(true);
        }
    }

}