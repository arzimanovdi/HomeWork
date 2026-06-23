namespace Task4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится натуральное число n. Найти n! Например, 6! = 1 * 2 * 3 * 4 * 5 * 6.
            int N;
            int s=1;
            Console.WriteLine("Введите натуральное число");
            N = Convert.ToInt32(Console.ReadLine());
            if (N >= 1)
            {
                for (int i = 1; i <= N; i++)
                {
                    s = s * i;
                }
                Console.WriteLine("{0}!={1}", N, s);
            }
            else
            {
                Console.WriteLine("Введите натуральное число!");
            }
            Console.ReadKey();
        }
    }
}
