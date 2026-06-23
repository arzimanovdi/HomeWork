namespace Task5_6_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Сформировать двумерный массив вида
            1 0 1 0 1
            0 1 0 1 0
            1 0 1 0 1
            0 1 0 1 0
            1 0 1 0 1
            */
            int[,] array = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = (((i + j) % 2 == 0) ? 1 : 0);
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
