namespace Task5_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 10 случайных чисел из диапазона [-20, 20].
            //Определить количество положительных, отрицательных и равных нулю элементов
            int positive_counter = 0;
            int negative_counter = 0;
            int zero_counter = 0;
            int[] array = new int[10];
            Random r_numb = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = r_numb.Next(-20, 21);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int[] array2 = array;
            foreach (int i2 in array2)
            {
                if (i2 == 0)
                {
                    zero_counter++;
                }
                else if (i2 > 0)
                {
                    positive_counter++;
                }
                else
                {
                    negative_counter++;
                }
            }
            Console.WriteLine("Кол-во положительных значений = {0}", positive_counter);
            Console.WriteLine("Кол-во отрицательных значений = {0}", negative_counter);
            Console.WriteLine("Кол-во нулевых значений = {0}", zero_counter);
            Console.ReadKey();
        }
    }
}
