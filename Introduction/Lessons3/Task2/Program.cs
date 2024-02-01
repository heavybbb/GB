


using System.Reflection.Metadata;

void PrintSquares(int limit)

{
    int i = 1;
    while (i <= limit)
    {
        Console.Write($"{i * i} ");
        i++;

    }

}

int q = 4;
int w = 2;
int e = 5;
PrintSquares(q);
PrintSquares(w);
PrintSquares(e);
