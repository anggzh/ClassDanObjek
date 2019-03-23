using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassDanObject

{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            saya.Nim = "18112297";
            saya.Nama = "Anggi Zhaputri";
            saya.Ipk = 3.92f;

            kamu.Nim = "18112298";
            kamu.Nama = "Zhaputri";
            kamu.Ipk = 3.92f;

            saya.Registrasi();
            saya.IsiKrs();

            kamu.Registrasi();
            kamu.IsiKrs();

            Console.ReadKey();
        }
    }
}
