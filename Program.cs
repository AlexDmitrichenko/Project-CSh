string[] signs = {"hello", "2", "world", ":-)"};
PrintArray(signs);
void PrintArray(string[] signs)
{
    int count = signs.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{signs[i]} ");
    }
    System.Console.WriteLine();
}
