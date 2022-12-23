namespace EX_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            try
            {
                var N = int.Parse(Console.ReadLine());
                int i = 2;

                while (i < (N-1))
                {
           
                    if (N % i == 0)
                    {
                        Console.WriteLine("TRUE");
                        break;
                    }
                    else
                    {
                        i++;
                    }

                    Console.WriteLine("FALSE");
                }
          
            }
            catch (Exception)
            {
                Console.WriteLine("Неверный тип данных1");
                throw;
            }
        }
    }
}