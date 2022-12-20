namespace EX_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Десятичные дроби записываются через запятую ','");
                Console.WriteLine("Введите цену 1 киллограмма конфет: ");
                var priseForOne = float.Parse(Console.ReadLine());

                Console.WriteLine("Введите вес конфет: ");
                var weight = float.Parse(Console.ReadLine());

                Console.WriteLine(priseForOne * weight);
            }
            catch (Exception)
            {
                Console.WriteLine("Введен неверный тип анных!");
                throw;
            }
        }
    }
}