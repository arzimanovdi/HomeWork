namespace Task3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится число. Вывести «Да», если оно оканчивается на 0, и «Нет» в противном случае.
            Console.WriteLine("Введите число:");
            double n = Convert.ToDouble(Console.ReadLine());
            string d = (n % 10 == 0) ? "Да" : "Нет";
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
