Console.Clear();

Console.WriteLine("print number n: ");
int n = int.Parse(Console.ReadLine()!);

int a = 1;

do 
{
    if (a % 2 == 0)
    {
        Console.WriteLine($"{a} ");
    }
    a++;
}
while (a < n);