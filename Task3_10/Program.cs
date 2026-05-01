namespace Task3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Застройщик построил n домов. Вывести фразу «Мы построили n домов»,
            //обеспечив правильное согласование числа со словом «дом», например:
            //20 — «Мы построили 20 домов», 32 — «Мы построили 32 дома»,
            //41 — «Мы построили 41 дом»
            Console.WriteLine("Сколько домов построено?");
            uint dom = Convert.ToUInt32(Console.ReadLine());
            // домов - 0,5,6-20,25-30
            // дом - 1,21,31
            // дома - 2,3,4,22-24
            if (dom % 10 == 0 || dom % 10 == 5 || dom % 10 >= 6 && dom % 10 <= 20)
            {
                Console.WriteLine("Мы построили {0} домов", dom);
            }
            else
            {
                if (dom % 10 >= 2 && dom % 10 <= 4)
                {
                    Console.WriteLine("Мы построили {0} дома", dom);
                }
                else
                {
                    Console.WriteLine("Мы построили {0} дом", dom);
                }
            }
            Console.ReadKey();

        }
    }
}
