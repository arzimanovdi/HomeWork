namespace Task5_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 50].
            //Найти и вывести значение максимального, минимального элементов и их индексы
            int maximum = 0;
            int index_max = 0;
            int minimum = 0;
            int index_min = 0;
            int[] array = new int[10];
            Random r_numb = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = r_numb.Next(0, 51);
                Console.Write("{0} ", array[i]);
            }
            int[] array2 = array;
            foreach (int x in array2)
            {
                maximum = array.Max();
                index_max = Array.IndexOf(array, maximum);
                minimum = array.Min();
                index_min = Array.IndexOf(array, minimum);
            }
            Console.WriteLine();
            Console.WriteLine("Максимальное значение = {0}, индекс = {1}", maximum, index_max);
            Console.WriteLine("Минимальное значение = {0}, индекс = {1}", minimum, index_min);
            Console.ReadKey();
        }
    }
}
