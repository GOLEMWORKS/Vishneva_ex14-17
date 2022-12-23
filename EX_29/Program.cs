namespace EX_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var bebrA = int.Parse(Console.ReadLine());

                if (bebrA <= 0)
                {
                    Console.WriteLine(bebrA * (-1));
                }
                else if (bebrA > 0 || bebrA < 2)
                {
                    Console.WriteLine(bebrA * bebrA);
                }
                else
                {
                    Console.WriteLine(4);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ебланоид, вводи цифорки а не букавки");
                throw;
            }
        }
    }
}