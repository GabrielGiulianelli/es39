namespace es39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double media=0, min=0, max=0;
            Console.WriteLine("Inserire il numero di persone");
            int persone=Convert.ToInt32(Console.ReadLine());
            int[] eta = new int [persone];
            double[] pesi = new double [persone];
             media = 0, min = pesi [0], max = pesi [0];
           double  accumulatore = 0;
            CaricaVettori(ref pesi, ref eta);
            Statistiche(ref pesi, ref media, ref min, ref max, ref accumulatore);
            Console.WriteLine($"La media dei pesi è {media} e il minimo è {min} e il massimo {max}");





        }


         static void CaricaVettori(ref double[] pesi,ref int[] eta)
        {
            Random random = new Random();
            for(int i=0; i<eta.Length; i++)
            {
                eta[i] = random.Next(18, 100);
                pesi[i] = random.Next(50, 101);
            }

        }
         static void Statistiche(ref double[] pesi, ref double media,ref double min,ref double max, ref double  accumulatore)
        {
            int i;
            for( i=1; i<pesi.Length; i++)
            {
                if (pesi[i] > max)
                {
                    max = pesi[i];

                }
                if (pesi[i] < min)
                {
                    min = pesi[i];
                }
                accumulatore += pesi[i];
                
                
                

            }
            media = accumulatore / i;

        }



    }
}