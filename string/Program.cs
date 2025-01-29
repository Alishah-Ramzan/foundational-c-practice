string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}
//formating in string like for currency :c and {0} {1} for using them in order
Console.WriteLine($"after else Measurement (w/ offset): {50 + result}\n");
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"\nPrice: {price:C} (Save {discount:C})");
string first = "Hello";
string second = "World";
string res = string.Format("{0} {1}!", first, second);
Console.WriteLine(res);
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

decimal price1 = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price1 - salePrice), price);

Console.WriteLine(yourDiscount);

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");

string input = "Pad  this ";
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));
//eg 2
string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("---------------------------------------");
Console.WriteLine(formattedLine);

string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition);

openingPosition += 1;

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));