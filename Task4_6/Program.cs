namespace Task4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится n. Определить, является ли оно степенью 2-ки?
            double n;
            Console.Write("Введите число: ");
            n = Convert.ToDouble(Console.ReadLine());
            while (n < 2)
            {
                n = Math.Sqrt(n);
            }
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
