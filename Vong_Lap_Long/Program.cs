using System;
namespace VongLapLong
{
    class VongLapLong 
    {
        public static void Main(string[] args)
        { 
            int t = int.Parse(Console.ReadLine());

            for (int i = 1 ; i <= t; i++)
            {
                Console.WriteLine($"Test {i} :");
                int n  = int.Parse(Console.ReadLine());
                int sum = 0;
                
                for (int j = 1 ; j < n; j++)
                {
                    if (n % j == 0)
                    {
                        sum = sum + j;
                    }
                }
                if (sum == n)
                {
                    Console.WriteLine("YES");

                }
                else { Console.WriteLine("NO"); };
                
            }    
        }
    }
}
