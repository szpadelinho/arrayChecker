using System;

class Program
{
    static void Main()
    {
        int[,] array = {{1, 2, 3, 20},{12, 13, 14, 15}};
        int value = 15;

        Tuple<int, int> index = searchIndex(array, value);
        if(index != null)
        {
            Console.WriteLine($"Twój szukany element ({value}) jest w indeksie [{index.Item1},{index.Item2}]");
        }
        else
        {
            Console.WriteLine($"Szukany przez Ciebie element ({value}) niestety nie został znaleziony w tablicy.");
        }
    }

    static Tuple<int, int> searchIndex(int[,] array, int value)
    {
        int row = array.GetLength(0);
        int col = array.GetLength(1);

        for(int x = 0; x < row; x++)
        {
            for(int y = 0; y < col; y++)
            {
                if(array[x, y] == value)
                {
                    return Tuple.Create(x, y);
                }
            }
        }
        return null;
    }
}