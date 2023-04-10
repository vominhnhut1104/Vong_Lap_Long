using System;
namespace VongLapLong
{
    class VongLapLong
    {
        public static void Main(string[] args)
        {
            var data = Console.ReadLine().Split(' ');

            int m = int.Parse(data[0]);
            int n = int.Parse(data[1]);

            for ( int i = 1; i <= m; i++ )
            {
                for ( int j = 1; j <= n; j++ )
                {
                    Console.Write("*"+" ");
                } 
                Console.WriteLine();
            }

        }
    }
}

