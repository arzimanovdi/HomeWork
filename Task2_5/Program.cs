namespace Task2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится длина трубы в метрах. Округлить длину до целых в большую сторону. Например, 

            // 17,0-> 17

            // 17,3-> 18

            // 17,7-> 18
            Console.WriteLine("Введите длину трубы в метрах");
            double TubingLength = Convert.ToDouble(Console.ReadLine());
            TubingLength = Math.Round(TubingLength,0,MidpointRounding.ToPositiveInfinity);
            Console.WriteLine("Длина трубы = {0} м", TubingLength);
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
