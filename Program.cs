string[] signs = { "hello", "2", "world", ":-)" };
int size = 0;
for (int x = 0; x < signs.Length; x++)
{
    if (signs[x].Length <= 3) size++;
}
Console.WriteLine($"[{String.Join(", ", Arraysigns(size))}]");
string[] Arraysigns(int size)
{
    string[] array = new string[size];
    int y = 0;
    for (int i = 0; i < signs.Length; i++)
    {
        if (signs[i].Length <= 3)
        {
            array[y] = signs[i]; y++;
        }
    }
    return array;
}

