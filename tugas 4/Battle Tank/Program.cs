using System;

namespace Battle_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variabel yang digunakan
            int dessertLength = 5;
            char tank = 't';
            char sand = '~';
            char hit = 'x';
            char miss = '0';
            int tankTotal = 3;

            //Buat array 2D untuk penempatan tank
            char[,] dessert = createDessert(dessertLength, sand, tank, tankTotal);

            //prinit Array 2D ke console
            printDessert(dessert, sand, tank);

            //Jumlah tank yang tersembunyi
            int unknownTankDetected = tankTotal;

            // game play
            while(unknownTankDetected > 0){
                int[]guessCoordinates = getUserCoordinate(dessertLength);
                char locationViewUpdate = verifyGuessAndTarget(guessCoordinates, dessert, tank, sand, hit, miss);
                if(locationViewUpdate == hit){
                    unknownTankDetected--; 
                }
                dessert = updateDessert(dessert, guessCoordinates, locationViewUpdate);
                printDessert(dessert, sand, tank);
            }

            Console.WriteLine("Game Over, Tank telah hancur..");
            Console.Read();            
        }

        //Print Array2D ke layar Console
        private static void printDessert(char[,] dessert,char sand, char tank){

            Console.Write("  ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + " ");
            }
            Console.WriteLine();

            for (int row = 0; row < 5; row++)
            {
                Console.Write(row + 1 + " ");
                for (int coloumn = 0; coloumn < 5; coloumn++)
                {
                    char position = dessert[row,coloumn];
                    if(position == tank){
                        Console.Write(sand + " ");
                    }else{
                        Console.Write(position + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        //cek validasi tebakan player (miss/kena/sudah hancur)
        private static char verifyGuessAndTarget(int[] guessCoordinates, char[,] dessert, char tank, char sand, char hit, char miss){
           
            string message;
            int row = guessCoordinates[0];
            int coloumn = guessCoordinates[1];
            char target = dessert[row, coloumn];

            if(target == tank){
                message = "Tebakan Benar!!";
                target = hit;
            }else if(target == sand){
                message = "Tebakan Meleset !!";
                target = miss;
            }else{
                message = "Sudah ditebak !!";
            }

            Console.WriteLine(message);
            return target;
        }

        //update tampilan Array2D berdasarkan hasil tebakan player
        private static char[,] updateDessert(char[,] dessert, int[] guessCoordinates, char locationViewUpdate){

            int row = guessCoordinates[0];
            int coloumn = guessCoordinates[1];
            dessert[row,coloumn] = locationViewUpdate;
            return dessert;
        }

        //tebakan Player (user Input)
        private static int[]getUserCoordinate(int dessertLength){
            int row;
            int coloumn;

            do{
                Console.Write("Pilih Baris : ");
                row = Convert.ToInt32(Console.ReadLine());
            }while(row<0 || row > dessertLength + 1);

            do{
                Console.Write("Pilih Kolom : ");
                coloumn = Convert.ToInt32(Console.ReadLine());
            }while(coloumn<0 || coloumn > dessertLength + 1);

            return new[]{row-1, coloumn-1};
        }

        //buat array 2D
        private static char[,] createDessert(int dessertLength, char sand, char tank, int tankTotal){
            char[,] dessert = new char [dessertLength, dessertLength];
            for (int row = 0; row < dessertLength; row++)
            {
                for (int coloumn = 0; coloumn < dessertLength; coloumn++)
                {
                    dessert[row,coloumn] = sand;
                }
            }

            return placeTanks(dessert, tankTotal, sand, tank);
        }

        //meletakkan 3 buah Tank didalam Array 2D
        private static char[,] placeTanks(char[,] dessert, int tankTotal, char sand, char tank){
            int placedTanks = 0;
            int dessertLength = 5;

            while(placedTanks < tankTotal){
                int[] tankLocation = gererateTankCoordinate(dessertLength);
                char positionOk = dessert[tankLocation[0], tankLocation[1]];

                if(positionOk == sand){
                    dessert[tankLocation[0], tankLocation[1]] = tank;
                    placedTanks++;
                }
            }

            return dessert;
        }
        
        //generate random positioon di dalam array2D
       private static int[] gererateTankCoordinate(int dessertLength){
        Random rnd = new Random();
        int[] coordinates = new int[2];
        for (int i = 0; i < coordinates.Length; i++)
        {
            coordinates[i] = rnd.Next(dessertLength);
        }

        return coordinates;
       }
    }

}
