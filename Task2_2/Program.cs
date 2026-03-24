namespace Task2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввод угла");
            Console.WriteLine("Введите градусы");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите минуты");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите секунды");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Значение угла в радианах:");
            double rad_degree = Math.PI / 180;
            double rad_minutes = Math.PI / (180 * 60);
            double rad_seconds = Math.PI / (180 * 60 * 60);
            double rad = a * rad_degree + b * rad_minutes + c * rad_seconds;
            Console.WriteLine("{0}", rad);
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
