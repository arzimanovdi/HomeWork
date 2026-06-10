namespace Task3_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится число. Вывести «Да», если оно попадает в диапазон [-10,10], и «Нет» в противном случае.
            Console.WriteLine("Введите число:");
            double n = Convert.ToDouble(Console.ReadLine());
            string d = (n >= -10 && n <= 10) ? "Да" : "Нет";
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
