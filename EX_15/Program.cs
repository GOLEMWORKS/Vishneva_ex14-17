namespace EX_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Введите номер месяца: ");
 
         var inputString = Console.ReadLine();
         bool res = int.TryParse( inputString , out int newInt);

            if (res == true)
            {
                switch (newInt)
                {
                    case 1 or 2 or 12:
                        Console.WriteLine("Зима");
                        break;
                    case 3 or 4 or 5:
                        Console.WriteLine("Весна");
                        break;
                    case 6 or 7 or 8:
                        Console.WriteLine("Лето");
                        break;
                    case 9 or 10 or 11:
                        Console.WriteLine("Лето");
                        break;
                    default:
                        Console.WriteLine("Введите число от 1 до 12");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Введён неверный формат данных!");
            }
         
        }
    }
}