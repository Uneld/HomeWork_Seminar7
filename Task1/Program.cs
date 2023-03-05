//HomeWork Task 1
Console.Clear();

System.Console.Write("Please enter number 1: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Please enter number 2: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"{a} > {b}");
}
else if (a < b)
{
    Console.WriteLine($"{a} < {b}");
}
else
{
    Console.WriteLine($"{a} = {b}");
}