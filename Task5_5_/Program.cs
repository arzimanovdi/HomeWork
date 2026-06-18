namespace Task5_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50, 50]. Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.
            //Вывести отсортированный таким образом массив на экран
            int[] array = new int[10];
            Random r_numb = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = r_numb.Next(-50, 51);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Первые пять элементов: ");
            for (int j = 0; j < 5; j++)
            {
                Console.Write("{0} ", array[j]);
            }
            Console.WriteLine();
            for (int k = 0; k < 4; k++)
            {
                for (int l = k + 1; l < 5; l++)
                {
                    if (array[k] > array[l])
                    {
                        int t = array[k];
                        array[k] = array[l];
                        array[l] = t;
                    }
                }
            }
            Console.WriteLine("Сортировка по возрастанию:");
            for (int m = 0; m < 5; m++)
            {
                Console.Write("{0} ", array[m]);
            }
            Console.WriteLine();
            Console.WriteLine("Вторые пять элементов: ");
            for (int n = 5; n < 10; n++)
            {
                Console.Write("{0} ", array[n]);
            }
            Console.WriteLine();
            for (int num = 5; num < 9; num++)
            {
                for (int num2 = num + 1; num2 < 10; num2++)
                {
                    if (array[num] < array[num2])
                    {
                        int t2 = array[num];
                        array[num] = array[num2];
                        array[num2] = t2;
                    }
                }
            }
            Console.WriteLine("Сортировка по убыванию:");
            for (int num3 = 5; num3 < 10; num3++)
            {
                Console.Write("{0} ", array[num3]);
            }
            Console.ReadKey();
        }
    }
}
