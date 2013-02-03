using System;
namespace odchylenie {
    class MainClass {
        public static void Main (string[] args) {
        Console.WriteLine("Podaj liczbę pomiarów");
        string gentoo = Console.ReadLine();
        int n = int.Parse(gentoo);
        double[] wartosci = new double [n];
        for (int i = 0; i < wartosci.Length; i++) {
            Console.Write("Podaj liczbę: ");
            string seba = Console.ReadLine();
            double x = double.Parse(seba);
            wartosci[i] = x;
        }
        double sum = 0;
        for (int i = 0; i <  wartosci.Length; i++) {
            sum = sum + wartosci[i];
        }
        double srednia = sum / n;

        for (int i = 0; i < wartosci.Length; i++){
            wartosci[i] -= srednia;
            wartosci[i] = Math.Pow(wartosci[i], 2);
        }
        double gora = 0;
        for (int i = 0; i < wartosci.Length; i++){
            gora +=wartosci[i];
        }
        gora = gora / (n*(n-1));
        double odchylenie = Math.Sqrt(gora);

        Console.WriteLine("Odchylenie standardowe wynosi: " + odchylenie);
        }
    }
}
