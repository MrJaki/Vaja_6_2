/*
 V osnovni datoteki Program.cs v metodi Main dodaj kodo, ki bo ustvari objekt tipa Pit_Trikotnik. 
Krak a naj bo dolg 6, krak b pa 8. Z uporabo metode na standardni izhod izpiši njegovo ploščino.
 */


namespace Vaja_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pit_Trikotnik trikotnik = new Pit_Trikotnik();
            trikotnik.NastaviStranice(6, 8, 10); // Nastavimo stranice a=6, b=8, c=10
            double ploscina = trikotnik.Ploscina(); // Izračunamo ploščino
            Console.WriteLine("Ploščina trikotnika je: " + ploscina); // Izpišemo ploščino

            Krog k = new Krog(6);

            Console.WriteLine(k.Ploscina());
        }
    }
}
