string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
string[] pallets1 = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets1, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallett in pallets1)
{
    Console.WriteLine($"-- {pallett}");
}

//array ki jagga khali hai magar baaki same place per hai
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine("\nresult: " + result);
Console.WriteLine("\n");
//reverse of string
char[] valueArray1 = value.ToCharArray();
Array.Reverse(valueArray1);
// string result = new string(valueArray);
string result1 = String.Join(",", valueArray1);
Console.WriteLine(result1);

string[] items = result1.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}
string pangram = "The quick brown fox jumps over the lazy dog";
Console.WriteLine("\n");
string[] words = pangram.Split(' ');
for (int i = 0; i < words.Length; i++)
{
    char[] charArray = words[i].ToCharArray();
    Array.Reverse(charArray);
    words[i] = new string(charArray);
}
string result_assignment = string.Join(" ", words);
Console.WriteLine(result_assignment);
//sorting assignment
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] itemss = orderStream.Split(',');
Array.Sort(itemss);

foreach (var item1 in itemss)
{
    if (item1.Length == 4)
    {
        Console.WriteLine(item1);
    }
    else
    {
        Console.WriteLine(item1 + "\t- Error");
    }
}