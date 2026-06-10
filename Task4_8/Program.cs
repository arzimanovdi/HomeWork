namespace Task4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится число. Вывести его в зеркальном виде.
            //Количество цифр в числе заранее неизвестно. Не использовать строки
            int n;
            int r = 0;
            int d;
            Console.Write("Введите число: ");
            n = Convert.ToInt32(Console.ReadLine());
            while(n>0)
            {
                d = n % 10;
                r = r * 10 + d;
                n = n / 10;
            }
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}
