namespace Task2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1.2.4: Вводится четырехзначное число. Поменять местами 2-ую и 4-ую цифру.
            Console.WriteLine("Введите четырехзначное число");
            int a = Convert.ToInt32(Console.ReadLine());
            int first = a / 1000;
            int second = a / 100 % 10;
            int third = a % 100 / 10;
            int fourth = a % 10;
            Console.WriteLine("{0}{1}{2}{3}", first, fourth, third, second);
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
