namespace Task4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводятся целые числа a>0, b<0. Найти a^b. Не использовать класс Math
            int a;
            int b;
            double s = 1.0;
            Console.Write("Введите целое число a>0:  ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите целое число b<0:  ");
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= b*(-1); i++)
            {
                s = s * a;
            }
            s = 1.0 / s;
            Console.WriteLine("Ответ: {0}", s);
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }
}
