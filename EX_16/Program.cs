namespace EX_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца: ");

            var inputString = Console.ReadLine();
            bool res = int.TryParse(inputString, out int newInt);

            if (res == true)
            {
                switch (newInt)
                {
                    case 1 or 3 or 5 or 7 or 8 or 10 or 12:
                        Console.WriteLine("31 день");
                        break;
                    case 4 or 6 or 9 or 11:
                        Console.WriteLine("30 дней");
                        break;
                    case 2:
                        Console.WriteLine("28 дней");
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