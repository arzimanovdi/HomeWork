namespace Task_5_10_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Клеточное поле размером n*n (n – константа на ваш выбор) состоит из 0 («ноликов») и 1 («крестиков»). 
            Проверить, выиграли ли «крестики»? 
            Считается, что «крестики» выиграли, если на поле найдется горизонталь, вертикали или диагональ из «крестиков».
            */
            Console.Write("Введите размерность клеточного поля n=");
            int n = Convert.ToInt32(Console.ReadLine());
            int row = 0;
            int col = 0;
            int main_diag = 0;
            int side_diag = 0;
            int[,] matrix = new int[n, n];
            Random r_numb = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //matrix[i, j] = (j == i) ? 1 : 0;
                    //matrix[i, j] = 1;
                    matrix[i, j] = r_numb.Next(0, 2);
                    Console.Write("{0,4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
            // проверка строк
            #region
            for (int i = 0; i < n; i++)
            {
                if (row == n)
                    break;
                else
                {
                    row = row * 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (matrix[i, j] == 0)
                            break;
                        else
                            row++;
                    }
                }
            }

            #endregion
            // проверка столбцов
            #region
            for (int j = 0; j < n; j++)
            {
                if (col == n)
                    break;
                else
                {
                    col = col * 0;
                    for (int i = 0; i < n; i++)
                    {
                        if (matrix[i, j] == 0)
                            break;
                        else
                            col++;
                    }
                }
            }
            #endregion
            // проверка главной диагонали
            #region
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j && matrix[i, j] == 1)
                        main_diag++;
                }
            }
            #endregion
            // проверка побочной диагонали
            #region
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    if ((i == -j + n - 1) && matrix[i, j] == 1)
                        side_diag++;
                }
            }
            #endregion
            // проверка условия
            if (row == n || col == n || main_diag == n || side_diag == n)
            {
                Console.WriteLine("выиграли");
            }
            else
            {
                Console.WriteLine("не выиграли");
            }
            Console.WriteLine($"{row,2},{col,2},{main_diag,2},{side_diag,2}");
            Console.ReadKey();
        }
    }
}
