string[] signs = {"hello", "2", "world", ":-)"};
Array(signs);
//Console.WriteLine($"[{String.Join(", ", signs)}]");
void Array(string[] signs)
{
    int count = signs.Length;
    for (int i = 0; i < count; i++)
    {
        if (signs[i].Length <= 3) System.Console.Write($"{signs[i]} ");//String.Join("; ",) 
    }
    System.Console.WriteLine();
}

