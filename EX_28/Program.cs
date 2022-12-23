namespace EX_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				var bebrA = int.Parse(Console.ReadLine());

				if (bebrA > 2)
				{
					Console.WriteLine(bebrA * 2);
				}
				else if (bebrA < -2)
				{
                    Console.WriteLine(bebrA * 2);
                }
				else
				{
					Console.WriteLine(bebrA * (-3));
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