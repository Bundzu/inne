using System;
namespace aproksymacja {
    class MainClass {
        public static void Main (string[] args) {
            double sumax = 0, sumay = 0, sumaxy = 0, sumaxkw = 0, sumaykw = 0;
            Console.Write ("Podaj liczbę pomiarów (n): ");
            string peja = Console.ReadLine ();
            int n = int.Parse (peja);
			
            for (int i=1; i<= n; i++) {
                Console.Write ("Podaj x" + i + ": ");
                string tibia = Console.ReadLine ();
                double x = double.Parse (tibia);
				
                Console.Write ("Podaj y" + i + ": ");
                string seba = Console.ReadLine ();
                double y = double.Parse (seba);
				
                sumax = sumax + x;
                sumay = sumay + y;
                sumaxy = sumaxy + x * y;
                sumaxkw = sumaxkw + x * x;
                sumaykw = sumaykw + y * y;
            }

            Console.WriteLine ("Wyniki: \n");
            Console.Write ("Σxi: " + sumax + "\t\t\t");
            Console.WriteLine ("Σyi: " + sumay);
            Console.Write ("Σxi²: " + sumaxkw + "\t\t\t");
            Console.WriteLine ("Σyi²: " + sumaykw);
            Console.WriteLine ("Σxiyi: " + sumaxy + "\n");
            
            double a = (sumax * sumay - n * sumaxy) / ((sumax * sumax) - n * sumaxkw);
            double b = (sumax * sumaxy - sumay * sumaxkw) / ((sumax * sumax) - n * sumaxkw);
            
            Console.WriteLine ("Rownanie prostej: f = " + a + " x + " + b + "\n");
            Console.WriteLine ("Niepewność: ");

            double sumadi = sumaykw - (a * sumaxy) - (b * sumay);
            Console.WriteLine ("Σdi: " + sumadi );

            double da = (Math.Sqrt (((1) / (n - 2)) * sumadi)) * (Math.Sqrt ((n) / (n * sumaxkw - (sumax * sumax))));
            Console.Write("Δa: "+ da+"\t\t\t");
			
            double db = (Math.Sqrt (( (1) / (n -2) )* sumadi ))* (Math.Sqrt ( (sumaxkw) / (n * sumaxkw - (sumax *sumax)))) ;
            Console.WriteLine ("Δb: "+ db);
            Console.ReadLine ();
        }
    }
}
