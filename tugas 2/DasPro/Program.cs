/*
Created by Azizah Fauni Saputri - 2207112594
Teknik Informatika - Universitas Riau
2022
*/

using System;

namespace DasPro
{
    class Program
    {
        //Deklarasi Variabel
        static int kodeA;
        static int kodeB;
        static int kodeC;
        static int jumlahKode;
        static int kesempatan = 3;
        static int level = 1;
        static string tebakanA;
        static string tebakanB;
        static string tebakanC;
        static bool bGameSelesai = true;
        static bool cancel = false;

        //Main Method
        static void Main(string[] args)
        {
            Intro();

            while(bGameSelesai){
                PlayGame();
                
                if(cancel == true){
                    break;
                }
            }
        }

        static void Intro(){
            //Intro
            Console.WriteLine("\nAnda adalah agen rahasia yang bertugas mendapatkan data dari server...");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui...");
            Console.WriteLine("\nGame telah dimulai...");
        }
            
        static void PlayGame(){
           
            //Inisialisasi Variabel
            Random rng = new Random();

            kodeA = rng.Next(1,level +1);
            kodeB = rng.Next(1,level +1);
            kodeC = rng.Next(1,level +1);

            jumlahKode = 3;

            //Operasi Aritmatika
            int hasilTambah = kodeA+kodeB+kodeC;
            int hasilKurang = kodeA-kodeB-kodeC;
            int hasilKali = kodeA*kodeB*kodeC;
            
            Console.WriteLine("\nLevel : " +level);
            Console.WriteLine("Kesempatan menjawab : " +kesempatan);
            Console.WriteLine("Password terdiri dari "+jumlahKode+" angka");
            Console.WriteLine("Jika Ditambahkan hasilnya "+hasilTambah);
            Console.WriteLine("Jika Dikurangkan hasilnya "+hasilKurang);
            Console.WriteLine("Jika Dikalikan hasilnya "+hasilKali);

            //Input User
            Console.WriteLine("\nAyo Tebak..!");
            Console.Write("\nKode Pertama : ");
            tebakanA = Console.ReadLine();
            Console.Write("Kode Kedua : ");
            tebakanB = Console.ReadLine();
            Console.Write("Kode Ketiga: ");
            tebakanC = Console.ReadLine();
            Console.WriteLine("Tebakan anda "+tebakanA+" "+tebakanB+" "+tebakanC+"?");

            if(tebakanA == kodeA.ToString() && tebakanB == kodeB.ToString() && tebakanC == kodeC.ToString()){
                Console.WriteLine("Tebakan anda benar...");

                //Tambah Level
                level = level + 1;

                if(level > 5)
                {
                    cancel = true;
                    Console.WriteLine("Selamat Anda Menang!");
                }
            }else{
                Console.WriteLine("Tebakan anda salah...");

                //Kesempatan Berkurang
                kesempatan = kesempatan - 1;
                
                if(kesempatan < 1)
                {
                    cancel = true;
                    Console.WriteLine("Game Over!");
                }
            }
        }
    }
}
