namespace Task3_4
{
    internal class Program
    {
        static void Main(string[] args)
        //Вводятся три разных числа. Вывести медиану.
        //Медиана - это число, которое в отсортированном ряду стоит "посередине".
        //Например, для чисел 3, 0, 9 медианой будет 3.
        {
            Console.WriteLine("Введите 3 числа:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введены 3 числа: {0}, {1}, {2}", a, b, c);
            double mediana;
            if ((a > b && a < c) || (a > c && a < b)) //Проверяет является ли переменная a медианой
            {
                mediana = a;
                Console.WriteLine("Медиана = {0}", mediana);
            }
            else
            {
                if ((b > c && b < a) || (b > a && b < c)) //Проверяет является ли переменная b медианой
                {
                    mediana = b;
                    Console.WriteLine("Медиана = {0}", mediana);
                }
                else
                {
                    mediana = c;
                    Console.WriteLine("Медиана = {0}", mediana);
                }
            }
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
