Console.Clear();

Console.Write("Введите номер четверти n: ");
int n = int.Parse(Console.ReadLine()!);

switch (n)
{
    case 1:
        Console.Write("x > 0; y > 0");
        break; 
    case 2:
        Console.Write("x < 0; y > 0");
        break; 
    case 3:
        Console.Write("x < 0; y < 0");
        break;
    case 4:
        Console.Write("x < 0; y < 0");
        break;
    default:
        Console.Write("Ввелите число от 1 до 4");
        break;
}    
