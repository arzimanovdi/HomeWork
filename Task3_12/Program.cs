using System.ComponentModel.Design;

namespace Task3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дано целое число в диапазоне 100–999.
            //Вывести строку-описание данного числа, например:
            //256 — «двести пятьдесят шесть», 814 — «восемьсот четырнадцать».
            //Если пользователь введёт данные не соответствующие условию задачи -
            //выдать сообщение об ошибке.
            //============================================
            //Объявление переменных
            int number;
            int hundreds;
            int tenth;
            int ones;
            string h;
            string t;
            string o;
            //Блок ввода данных
            Console.WriteLine("Введите целое число в диапазоне от 100 до 999");
            number = Convert.ToInt16(Console.ReadLine());
            hundreds = number / 100;
            tenth = number / 10 % 10;
            ones = number % 10;
            Console.WriteLine("{0}{1}{2}", hundreds, tenth, ones);
            //Процедурный блок
            if (number < 100 || number > 999)
            {
                Console.WriteLine("Ошибка");
            }
            else
            {
                switch (hundreds)
                {
                    case 1:
                        {
                            h = "Сто";
                            Console.Write(h);
                            break;
                        }
                    case 2:
                        {
                            h = "Двести";
                            Console.Write(h);
                            break;
                        }
                    case 3:
                        {
                            h = "Триста";
                            Console.Write(h);
                            break;
                        }
                    case 4:
                        {
                            h = "Четыреста";
                            Console.Write(h);
                            break;
                        }
                    case 5:
                        {
                            h = "Пятьсот";
                            Console.Write(h);
                            break;
                        }
                    case 6:
                        {
                            h = "Шестьсот";
                            Console.Write(h);
                            break;
                        }
                    case 7:
                        {
                            h = "Семьсот";
                            Console.Write(h);
                            break;
                        }
                    case 8:
                        {
                            h = "Восемьсот";
                            Console.Write(h);
                            break;
                        }
                    case 9:
                        {
                            h = "Девятьсот";
                            Console.Write(h);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ошибка");
                            break;
                        }

                }
                switch (tenth)
                {
                    case 0:
                        {
                            break;
                        }
                    case 1:
                        {
                            switch (ones)
                            {
                                case 0:
                                    {
                                        Console.Write("Десять");
                                        break;
                                    }
                                case 1:
                                    {
                                        Console.Write("Одиннадцать");
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Write("Двенадцать");
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.Write("Тринадцать");
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.Write("Четырнадцать");
                                        break;
                                    }
                                case 5:
                                    {
                                        Console.Write("Пятнадцать");
                                        break;
                                    }
                                case 6:
                                    {
                                        Console.Write("Шестнадцать");
                                        break;
                                    }
                                case 7:
                                    {
                                        Console.Write("Семьнадцать");
                                        break;
                                    }
                                case 8:
                                    {
                                        Console.Write("Восемьнадцать");
                                        break;
                                    }
                                case 9:
                                    {
                                        Console.Write("Девятнадцать");
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Ошибка");
                                        break;
                                    }
                            }
                            break;
                        }
                    case 2:
                        {
                            t = "Двадцать";
                            Console.Write(t);
                            break;
                        }
                    case 3:
                        {
                            t = "Тридцать";
                            Console.Write(t);
                            break;
                        }
                    case 4:
                        {
                            t = "Сорок";
                            Console.Write(t);
                            break;
                        }
                    case 5:
                        {
                            t = "Пятьдесят";
                            Console.Write(t);
                            break;
                        }
                    case 6:
                        {
                            t = "Шестьдесят";
                            Console.Write(t);
                            break;
                        }
                    case 7:
                        {
                            t = "Семьдесят";
                            Console.Write(t);
                            break;
                        }
                    case 8:
                        {
                            t = "Восемьдесят";
                            Console.Write(t);
                            break;
                        }
                    case 9:
                        {
                            t = "Девяносто";
                            Console.Write(t);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ошибка");
                            break;
                        }
                }
                if (tenth == 1)
                {
                    o = "";
                }
                else
                {
                    switch (ones)
                    {
                        case 0:
                            {
                                break;
                            }
                        case 1:
                            {
                                o = "Один";
                                Console.Write(o);
                                break;
                            }
                        case 2:
                            {
                                o = "Два";
                                Console.Write(o);
                                break;
                            }
                        case 3:
                            {
                                o = "Три";
                                Console.Write(o);
                                break;
                            }
                        case 4:
                            {
                                o = "Четыре";
                                Console.Write(o);
                                break;
                            }
                        case 5:
                            {
                                o = "Пять";
                                Console.Write(o);
                                break;
                            }
                        case 6:
                            {
                                o = "Шесть";
                                Console.Write(o);
                                break;
                            }
                        case 7:
                            {
                                o = "Семь";
                                Console.Write(o);
                                break;
                            }
                        case 8:
                            {
                                o = "Восемь";
                                Console.Write(o);
                                break;
                            }
                        case 9:
                            {
                                o = "Девять";
                                Console.Write(o);
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Ошибка");
                                break;
                            }
                    }
                }
            }
            //Блок вывода
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
