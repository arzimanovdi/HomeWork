namespace Task4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится натуральное число n. Найти 1 + 1/2 + 1/3 + … + 1/n
            int N;
            double s = 1.0;
            Console.WriteLine("Введите натуральное число");
            N = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= N; i++)
            {
                s = s + 1.0 / i;
            }
            Console.WriteLine("Ответ: {0}", s);
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
