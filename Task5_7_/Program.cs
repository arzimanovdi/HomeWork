namespace Task5_7_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сформировать двумерный массив из 10 строк и 5 столбцов.
            //Заполнить его случайными числами в диапазоне [0, 10].
            //Определить максимальный элемент в каждой строке
            int[,] array = new int[10, 5];
            Random r_numb = new Random();
            for (int i = 0; i < 10; i++)
            {
                int maximum = array[i,0];
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = r_numb.Next(0,11);
                    Console.Write("{0} ", array[i, j]);
                    if (array[i, j] > maximum)
                    {
                        maximum = array[i, j];
                    }
                }
                Console.Write($"   Строка {i}: Максимальное значение = {maximum}");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
