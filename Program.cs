int[,] arr = new int[6, 6]
{
    { 5, 2, 6, 7, 8, 2 },
    { 1, 7, 2, 5, 0, 8 },
    { 4, 7, 2, 8, 9, 4 },
    { 2, 5, 1, 1, 7, 9 },
    { 6, 2, 3, 9, 9, 1 },
    { 4, 1, 7, 2, 3, 5 },
};

int height = arr.GetLength(0);
int weight = arr.GetLength(1);

//RenderNormalArr();
ChangeArr();
RenderChangedArr();

void RenderNormalArr()
{
    for (int i = 0; i < height; ++i)
    {
        for (int j = 0; j < weight; ++j)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void RenderChangedArr()
{
    for (int i = 0; i < height; ++i)
    {
        for (int j = 0; j < weight; ++j)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void ChangeArr()
{
    for (int i = 0; i < 3; ++i)
    {
        for (int j = 0; j < 6; ++j)
        {
            int temp = arr[j, i + 3];
            arr[j, i + 3] = arr[j, i];
            arr[j, i] = temp;
        }
    }
}