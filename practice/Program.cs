int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0; // Initialize total outside the loop
bool found = false; // Initialize found outside the loop

foreach (int number in numbers)
{
    total += number; // Add number to total

    if (number == 42)
    {
        found = true; // Set found to true if number is 42
    }
}

if (found)
{
    Console.WriteLine("Set contains 42");
}
Console.WriteLine("practice typepopular fruit name");
string fruit = Console.ReadLine();
switch (fruit)
{
    case "apple":
        Console.WriteLine($"App will display information for apple.");
        break;

    case "banana":
        Console.WriteLine($"App will display information for banana.");
        break;

    case "cherry":
        Console.WriteLine($"App will display information for cherry.");
        break;
}