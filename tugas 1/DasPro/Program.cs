using System;

namespace DasPro
{
    class Program
    {
        static void Main(string[] args)
        {
            const int a = 5;
            const int b = 4;
            const int c = 7;

            int tambah = a+b+c;
            int kali = a*b*c;
            int kurang = a-b-c;
            int bagi = a/b/c;

            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server");
            Console.WriteLine("Akses ke server membutuhkan pasword yang tidak diketahui..");
            Console.WriteLine("- pasword terdiri dari 4 angka");
            Console.WriteLine("- jika ditambah hasilnya "+tambah);
            Console.WriteLine("- jika ditambah hasilnya "+kali);
            Console.WriteLine("- jika ditambah hasilnya "+kurang);
            Console.WriteLine("- jika ditambah hasilnya "+bagi);

            Console.WriteLine("");
            Console.WriteLine("Enter Code : ");
        }
    }
}
