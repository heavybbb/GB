void ZeroEvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }

}
void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}
int[] array = { 1, 2, 3, 4, 5 };
ZeroEvenElements(array);
//PrintArray(array);
Console.Write({ array});



Random rnd = new Random();

int size = 1000;
int[] arr_int = new int[size];
int i = 0;
while (i < size)
{
    arr_int[i] = rnd.Next(1, 10);
    i = ++i;

}
i = 0;
while (i < size)
{
    Console.Write($"{arr_int[i]} ");
    i = ++i;
}