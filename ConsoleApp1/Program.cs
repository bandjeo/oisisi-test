// See https://aka.ms/new-console-template for more information
Console.WriteLine("Pls give number: ");

string s = Console.ReadLine();

int n = Convert.ToInt32(s);
bool hasThree = false;
while (n > 0)
{
    if (n % 10 == 3)
    {
        hasThree = true;
        break;
    }
    n /= 10;
}
if (hasThree)
{
    Console.WriteLine("Number contains 3");
} else
{
    Console.WriteLine("Number does not contain 3");
}
