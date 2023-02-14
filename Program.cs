string[] signs = {"hello", "2", "world", ":-)"};

// int size = 0;
// while (size <= signs.Length) 
// {
//     if (signs[size].Length < 3);
// string[size] newsings = signs[size]
// }
PrintArray(signs);
void PrintArray(string[] signs)
{
    int count = signs.Length;
    for (int x = 0; x < count; x++)
    {
        System.Console.Write($"{signs[x]} ");
    }
    System.Console.WriteLine();
}

