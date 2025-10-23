namespace Vaja_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Krog k1 = new Krog(6);
            Krog k2 = new Krog(5);

            Console.WriteLine(k1.Ploscina());
            Console.WriteLine(k1.Obseg());
            Console.WriteLine(k2.Ploscina());
            Console.WriteLine(k2.Obseg());
        }
    }
}
