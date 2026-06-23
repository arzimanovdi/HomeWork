namespace Task5_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 100].
            //Определить, каких чисел больше – четных или нечетных
            int even_counter = 0;
            int odd_counter = 0;
            int[] array = new int[100];
            Random r_numb = new Random();
            for (int i = 0; i < 100; i++)
            {
                array[i] = r_numb.Next(0, 101);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int[] array2 = array;
            foreach (int i2 in array2)
            {
                if (i2 % 2 == 0)
                {
                    even_counter++;
                }
                else
                {
                    odd_counter++;
                }
            }
            Console.WriteLine("Кол-во четных: {0}", even_counter);
            Console.WriteLine("Кол-во нечетных: {0}", odd_counter);
            if (even_counter == odd_counter)
            {
                Console.WriteLine("четных и нечетных одинаковое количество");
            }
            else if (even_counter > odd_counter)
            {
                Console.WriteLine("четных больше");
            }
            else
            {
                Console.WriteLine("нечетных больше");
            }
            Console.ReadKey();
        }
    }
}
