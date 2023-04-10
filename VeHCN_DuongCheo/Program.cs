using System;
namespace VongLapLong
{
    class VongLapLong
    {
        public static void Main(string[] args)
        {
            
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (i == 1 || j == 1 || i == n || j == n
                            || i == j || i + j == n + 1) // vẽ đường chéo chính và phụ vd n[2,2] thì in ra, phần tử trên đường chéo chính
                                                            // đương chéo phụ thì quy luật là i+ j = n+1; ví dụ h = 6; phần tử n[3,4] = n+ 6 thì vẽ nó ra

                        {
                            Console.Write(" * ");
                        }
                        else
                        {
                            Console.Write("   ");
                        }
                    }
                    Console.WriteLine();
                }
            
        }
    }
}

