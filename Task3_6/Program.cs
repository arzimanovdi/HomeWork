namespace Task3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится число. Вывести «Да», если оно четное, и «Нет» в противном случае.
            Console.WriteLine("Введите число:");
            double n = Convert.ToDouble(Console.ReadLine());
            string d = (n % 2 == 0) ? "Да" : "Нет";
            Console.WriteLine(d);
            Console.ReadKey();

        }
    }
}
