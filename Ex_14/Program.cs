namespace Ex_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите оценку: ");   
            switch (Console.ReadLine())
            {
                case "1": Console.WriteLine("Плохо");
                    break;
                case "2":
                    Console.WriteLine("Неудовлетворительно");
                    break;
                case "3":
                    Console.WriteLine("Удовлетворительно");
                    break;
                case "4":
                    Console.WriteLine("Хорошо");
                    break;
                case "5":
                    Console.WriteLine("Отлично");
                    break;
                default:
                    Console.WriteLine("Диапазон отметки от 1 до 5!!!");
                    break;
            }
        }
    }
}