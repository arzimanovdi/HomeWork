namespace Task2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите переменную a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите переменную b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите переменную c");
            int c = Convert.ToInt32(Console.ReadLine());
            int t = a;
            int v = b;
            a = c;
            b = t;
            c = v;
            Console.WriteLine("a={0}, b={1}, c={2}", a, b, c);
            Console.WriteLine("Введите любую клавишу");
            Console.ReadKey();
        }
    }
}
