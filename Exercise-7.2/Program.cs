namespace Exercise_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine($"Loop cycle: {i}");
                if (i == 5000)
                {
                    Console.WriteLine(args[999]);
                }
            }
        }
    }
}
