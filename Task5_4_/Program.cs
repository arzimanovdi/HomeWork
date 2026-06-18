namespace Task5_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 10].
            //Перевернуть массив, т.е. переставить элементы массива в обратном порядке
            int[] array = new int[10];
            Random r_numb = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = r_numb.Next(0, 11);
                Console.Write("{0} ", array[i]);
            }
            Array.Reverse(array);
            Console.WriteLine();
            for (int j = 0; j < 10; j++)
            {
                Console.Write("{0} ", array[j]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
