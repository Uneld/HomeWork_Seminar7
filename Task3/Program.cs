//HomeWork Task 3
Console.Clear();

System.Console.Write("Please enter number: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 != 0)
{
    Console.WriteLine($"Number {a} is odd"); //нечетное
}
else
{
    Console.WriteLine($"Number {a} is even"); //четное
}