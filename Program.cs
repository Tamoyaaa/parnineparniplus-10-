namespace parnineparniplus_10_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            int n = int.Parse(Console.ReadLine());

            int koliche = 0;
            int sum = 0;
            int i = 1;

            while (i <= n)
            {
                if (i % 2 != 0)
                {
                    koliche++;
                    sum += i;
                }
                i++;
            }
            Console.WriteLine($"Количетсво нечетных чисел:{koliche}");
            Console.WriteLine($"Сумма нечетных чисел:{sum}");
        }
    }
}
