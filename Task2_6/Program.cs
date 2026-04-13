using System.Security.Cryptography;

namespace Task2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вводится длина трубы в метрах. Округлить длину до 0,5. Например, 
            // 17,01-> 17
            //17,099-> 17
            //17,1 -> 17
            //17,51 -> 17,5
            //17,6 -> 17,5
            Console.WriteLine("Введите значение длины трубы в метрах:");
            double TubingLength = Convert.ToDouble(Console.ReadLine()); //вводим например 17.6
            double a = TubingLength * 10.0 / 5; //176/5=35.2
            a = Math.Round(a, 0, MidpointRounding.ToEven); //35.2=35 округлит к ближайшему целому
            double res = a / 10.0 * 5; // 3.5*5=17.5
            Console.WriteLine("Длина трубы = {0} м", res);
            Console.WriteLine("Для завершения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
