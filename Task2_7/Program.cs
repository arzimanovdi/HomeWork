namespace Task2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводятся два числа. Обменять их местами, не используя третью переменную.
            Console.WriteLine("Введите значения переменных");
            int a = Convert.ToInt32(Console.ReadLine()); 
            int b = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("переменная a = {0}", a);
            Console.WriteLine("переменная b = {0}", b);
            a = b + a; 
            b = a - b; 
            a = a - b;
            Console.WriteLine("переменная а = {0}, переменная b = {1}", a, b);
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
