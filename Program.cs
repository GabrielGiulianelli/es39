namespace es39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserire il numero di persone");
            int persone=Convert.ToInt32(Console.ReadLine());
            int[] eta = new int [persone];
            double[] pesi = new double [persone];



            kbhkibhiyhuihih
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
         static void Statistiche(ref double[] pesi, ref double media,ref double min,ref double max)
        {

        }



    }
}