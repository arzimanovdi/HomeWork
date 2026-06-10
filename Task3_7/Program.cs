namespace Task3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится число. Вывести «Да», если оно двухзначное, и «Нет» в противном случае
            Console.WriteLine("Введите число:");
            double n = Convert.ToDouble(Console.ReadLine());
            string d = (n>=10 && n <100) ? "Да" : "Нет";
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
