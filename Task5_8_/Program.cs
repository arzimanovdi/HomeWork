namespace Task5_8_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 5 случайных чисел из диапазона [0, 10].
            //Найти два наибольших элемента. Например, среди чисел {4, 8, 0, 9, 3} два наибольших числа – 9 и 8.
            //Среди чисел {5, 9, 1, 9, 3} два наибольших числа – 9 и 9
            int[] array = new int[5];
            int maximum = 0;
            int maximum2 = 0;
            int index_max = 0;
            Random r_numb = new Random();
            for (int i = 0; i < 5; i++)
            {
                array[i] = r_numb.Next(0, 11);
                Console.Write(" {0}", array[i]);
            }
            Console.WriteLine();
            foreach (int i2 in array)
            {
                maximum = array.Max();
                index_max = Array.IndexOf(array, maximum);

            }
            Console.WriteLine("Максимальное значение 1 = {0}, индекс = {1}", maximum, index_max);
            int[] array2 = new int[array.Length - 1];
            Array.Copy(array, 0, array2, 0, index_max);
            Array.Copy(array, index_max + 1, array2, index_max, array.Length - index_max - 1);
            array = array2;
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" {0}", array[i]);
            }
            Console.WriteLine();
            foreach (int i3 in array)
            {
                maximum2 = array.Max();
            }
            Console.WriteLine("Максимальное значение 2 = {0}", maximum2);
            Console.ReadKey();
        }
    }
}
