namespace Task3_2
{
    internal class Program
    {
        static void Main(string[] args)
        //Вводятся три числа. Вывести большее их них.
        {
            Console.WriteLine("Введите 3 числа");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введены числа {0}, {1} , {2}", a, b, c);
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("Наибольшее число = {0}", a);
                }
                else
                {
                    Console.WriteLine("Наибольшее число = {0}", c);
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("Наибольшее число = {0}", b);
                }
                else
                {
                    Console.WriteLine("Наибольшее число = {0}", c);
                }
            }
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
