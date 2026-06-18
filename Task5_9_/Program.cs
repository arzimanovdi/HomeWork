namespace Task5_9_
{
    internal class Program
    {
        static void Main()
        {
            /* Матрицу A(m,n) (m и n – константы со значением на ваш выбор) 
              заполнить натуральными числами от 1 до n*m по спирали,
              начинающейся в левом верхнем углу и закрученной по часовой стрелке
                Например,
                1   2  3  4 5
                16 17 18 19 6
                15 24 25 20 7
                14 23 22 21 8
                13 12 11 10 9
            */
            Console.Write("Введите кол-во строк = ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите кол-во столбцов = ");
            int cols = Convert.ToInt32(Console.ReadLine());
            int[,] matrix2 = new int[rows, cols];
            int value = 1;
            int top = 0, bottom = rows - 1;
            int left = 0, right = cols - 1;
            while (top <= bottom && left <= right)
            {
                // Слева направо
                for (int i = left; i <= right; i++)
                {
                    matrix2 [top, i] = value++;
                }
                top++;
                //Сверху вниз
                for (int i = top;  i <= bottom; i++)
                {
                    matrix2[i,right] = value++;
                }
                right--;
                if (top <= bottom)
                {
                    //Справа налево
                    for (int i = right; i >= left; i--)
                    {
                        matrix2[bottom, i] = value++;
                    }
                    bottom--;
                }
                if (left <= right)
                {
                    //Снизу вверх
                    for (int i = bottom; i >= top; i--)
                    {
                        matrix2[i, left] = value++;
                    }
                    left++;
                }
            }
            PrintMatrix(matrix2);
            Console.ReadKey ();
        }
        static void PrintMatrix(int[,] matrix2)
        {
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Console.Write($"{matrix2[i, j],3} ");
                }
                Console.WriteLine();
            }
        }
    }
}