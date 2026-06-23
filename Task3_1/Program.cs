namespace Task3_1
{
    internal class Program
    {
        static void Main(string[] args)
        //Вводятся два числа. Сравнить их и вывести правильный знак «<», «>» или «=».
        {

            Console.WriteLine("Введите два числа");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("a={0}", a);
            Console.WriteLine("b={0}", b);
            if (a != b)
            {
                if (a > b)
                {
                    Console.WriteLine("{0} > {1}", a, b);
                }
                else
                {
                    Console.WriteLine("{0} < {1}", a, b);
                }
            }
            else
            {
                Console.WriteLine("{0} = {1}", a, b);
            }
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
