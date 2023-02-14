string[] signs = {"hello", "2", "world", ":-)"};
// void NewArray(string[] signs)
// {
// for (int i = 0; i < signs.Length; i++)
// {
//     if (signs[i].Length <= 3) signs[i] = signs[i];
// }
// }
// // int size = 0;
// // while (size <= signs.Length) 
// // {
// //     if (signs[size].Length < 3);
// // string[size] newsings = signs[size]
// // }
// NewArray (signs);
PrintArray(signs);
void PrintArray(string[] signs)
{
    int count = signs.Length;
    for (int i = 0; i < count; i++)
    {
        if (signs[i].Length <= 3) System.Console.Write($"{signs[i]} ");
    }
    System.Console.WriteLine();
}

