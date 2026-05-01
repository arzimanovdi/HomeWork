namespace Task3_3
{
    internal class Program
    {
        static void Main(string[] args)
        //Вводятся четыре числа. Вывести большее из них.
        {
            Console.WriteLine("Введите 4 числа");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            double max = Math.Max(Math.Max(a, b), Math.Max(c, d));
            Console.WriteLine("Наибольшее число = {0}", max);
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
