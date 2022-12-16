using System;

namespace dadu
{
    class Program
    {

        static void Main(string[] args)
        {
            //intro
            Console.WriteLine("Pada game ini anda dan komputer akan bermain 10 ronde");
            Console.WriteLine("Setiap putaran dadu akan dilempar menghasilkan nilai tertentu");
            Console.WriteLine("Nilai dadu tertinggi akan menjadi pemenang ronde tersebut");
            Console.WriteLine("Siapa yang akan menang? Selamat berjuang");
            Console.WriteLine("\nMulai main...");

            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("\ntekan tombol enter");

                Console.ReadKey();

                playerRandomNum = random.Next(1,7);
                Console.WriteLine("Kamu mendapatkan angka "+playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1,7);
                Console.WriteLine("Musuh mendapatkan angka "+enemyRandomNum);

                if(playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("kamu memenangkan ronde ini!");
                }else if(playerRandomNum < enemyRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("Musuh memenangkan ronde ini!");
                }else{
                    Console.WriteLine("Permainan Seri!");
                }
                Console.WriteLine("skor kamu : " +playerPoints+ ". musuh : " +enemyPoints+ ".");
                Console.WriteLine();

            }

            if(playerPoints > enemyPoints){
                Console.WriteLine("Selamat, kamu memenangkan game ini!");
            }else if(playerPoints< enemyPoints){
                Console.WriteLine("Kamu kalah!");
            }else{
                Console.WriteLine("Seri!");
            }

            Console.ReadKey();
        }

    }
}
