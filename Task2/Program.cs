//HomeWork Task 2
Console.Clear();

System.Console.Write("Please enter number 1: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Please enter number 2: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Please enter number 3: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}

Console.WriteLine($"Max of numbers = {max}");
