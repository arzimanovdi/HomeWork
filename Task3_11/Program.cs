using System.ComponentModel.Design;

namespace Task3_11
{
    internal class Program
    {
        static void Main(string[] args)
        //Можно ли на прямоугольном участке застройки размером a * b метров разместить два дома размером в плане p * q и r * s метров?
        //Дома можно располагать только параллельно сторонам участка. Дома могу стоять «вплотную» друг к другу.
        {
            //Объявление переменных
            double a;
            double b;
            double p;
            double q;
            double r;
            double s;
            //Блок ввода данных
            Console.WriteLine("Введите размеры участка в метрах:");
            Console.WriteLine("Сторона a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сторона b=");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите размеры первого дома в метрах:");
            Console.WriteLine("Сторона p=");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сторона q=");
            q = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите размеры второго дома в метрах:");
            Console.WriteLine("Сторона r=");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сторона s=");
            s = Convert.ToDouble(Console.ReadLine());
            //Блок решателя
            if (((p + s) <= b && (q + r) <= a) ||
                ((q + r) <= b && (p + s) <= a) || 
                ((p + r) <= b && (q + s) <= a) || 
                ((q + s) <= b && (p + r) <= a)||
                ((p==a)&&(r+q)<=b) ||
                ((p==a)&&(s+q)<=b) ||
                ((q==a)&&(r+p)<=b) ||
                ((q==a)&&(s+p)<=b) ||
                ((r==a)&&(p+q)<=b) ||
                ((r==a)&&(p+s)<=b) ||
                ((s==a)&&(p+r)<=b) ||
                ((s==a)&&(p+q)<=b) ||
                ((p==b)&&(r+s)<=a) ||
                ((p==b)&&(r+q)<=a) ||
                ((q==b)&&(r+s)<=a) ||
                ((q==b)&&(r+p)<=a) ||
                ((r==b)&&(p+q)<=a) ||
                ((r==b)&&(p+s)<=a) ||
                ((s==b)&&(p+r)<=a) ||
                ((s==b)&&(p+q)<=a))
            //Блок вывода
            {
                Console.WriteLine("Дома вмещаются в заданную площадь");
            }
            else
            {
                Console.WriteLine("Дома не вмещаются в заданную площадь");
            }
            Console.ReadKey();
        }
    }
}
