//HomeWork Task 4
Console.Clear();

System.Console.Write("Please enter number: ");
int a = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= a; i += 2)
{
    Console.Write($"{i} ");
}