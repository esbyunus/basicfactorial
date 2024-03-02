namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number whose factorial you want to calculate: ");
            int number = Convert.ToInt32(Console.ReadLine());
            static int FactorialCalculator( int n )
                if (n == 0)
                    return 1;
                else 
                    return n * FactorialCalculator(n - 1);
        }

            int answer = FactorialCalculator(number);
            Console.WriteLine($"factorial: {answer}");
        }
    }
}