using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemograman2861
{
    public class Karyawan
    {
        public Karyawan(int urut, int Nomer, string Name, int GajiBul)
        {
            URUT = urut;
            NIK = Nomer;
            NAMA = Name;
            GAJI = GajiBul;

        }

        public int URUT { get; set; }
        public int NIK { get; set; }
        public string NAMA { get; set; }
        public int GAJI { get; set; }

        public void Cetak()
        {
            Console.WriteLine("{0}. {1}  {2}           {3}", URUT, NIK, NAMA, GAJI);
            if (GAJI < 0)
            {
                Console.WriteLine("Maaf Gaji kurang dari 0");
            }

        }
        public void CetakNaik()
        {
            Console.WriteLine("{0}. {1}  {2}           {3}", URUT, NIK, NAMA, GAJI + (GAJI * 0.1));
            if (GAJI < 0)
            {
                Console.WriteLine("Maaf Gaji kurang dari 0");
            }
        }
    }
}