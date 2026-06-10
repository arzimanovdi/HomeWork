namespace Task4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится n. Определить количество цифр в числе
            int n;
            int s = 0;
            Console.Write("Введите число: ");
            n = Convert.ToInt32(Console.ReadLine());
            do
            {
                n = n / 10;
                s = s + 1;
            }
            while (n>0);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
