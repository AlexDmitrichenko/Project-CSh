string[] signs = { "hello", "2", "world", ":-)" };
string [] newsigns = array(signs);
Console.WriteLine($"[{String.Join(", ", newsigns)}]");
// Array(signs);
// //Console.WriteLine($"[{String.Join(", ", signs)}]");
// void Array(string[] signs)
// {
//     int count = signs.Length;
//     for (int i = 0; i < count; i++)
//     {
//         if (signs[i].Length <= 3) System.Console.Write($"{signs[i]} ");//String.Join("; ",) 
//     }
//     System.Console.WriteLine();
// }
string[] array (string[] signs)
{
  string[] array = new string[signs.Length];
  for (int i = 0; i < signs.Length; i++)
  {
    if (signs[i].Length <= 3) array[i] = signs[i];
  }
 return array;
}

