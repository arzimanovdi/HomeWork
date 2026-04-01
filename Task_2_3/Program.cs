namespace Task_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // вводится значение дюймов и конвертируется в метрическую систему.
            // пример: 101,1 дюймов это 2 метр 56 сантиметр 7,9 миллиметр.
            Console.WriteLine("Введите значение длины отрезка в дюймах, для разделителя используйте ,: ");
            double inch = Convert.ToDouble(Console.ReadLine());
            double metric = inch * 25.4;
            double m = Math.Round(metric * 0.001, 0, MidpointRounding.ToZero);
            double cm = Math.Round(metric * 0.1, 0, MidpointRounding.ToZero)%100;
            double mm = Math.Round(metric % 10, 1);
            Console.WriteLine("{0}дюйм это {1} метр {2} сантиметр {3} миллиметр", inch, m, cm, mm);
            Console.WriteLine("Введите любую клавишу");
            Console.ReadKey();
        }
    }
}
