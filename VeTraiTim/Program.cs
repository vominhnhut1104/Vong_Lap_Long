int height = 6;
int width = 7;

int i, j;
for (i = 1; i < 7; i++)
{
    for (j = 1; j <= 7; j++)
    {
        if (!((i == 1 && (j == 1 || j == 4 || j == 7))
        || (i == 4 && (j == 1 || j == 7))
        || (i == 5 && (j <= 2 || j >= 6))
        || (i == 6 && (j <= 3 || j >= 5))))
        {
            Console.Write(" * ");
        }
        else
        {
            Console.Write("   ");
        }
    }
    Console.Write("\n");
}