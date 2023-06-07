// Задача 3: Напишите программу, которая будет выдавать название дня недели по заданнлму номеру.
// 3->  среда
// 5->  пятница

Console.Write("Enter your number of day: ");
int number = int.Parse(Console.ReadLine()!);

if (number == 1)
{
    Console.WriteLine("Monday");
}

else if  (number == 2)
{
    Console.WriteLine("Tuesday");
}

else if (number == 3)
{
    Console.WriteLine("Wednesday");
}

else if (number == 4)
{
    Console.WriteLine("Fourday");
}

else if (number == 5)
{
    Console.WriteLine("friday");
}

else if  (number == 6)
{
    Console.WriteLine("Suturday");
}

else if (number == 7)
{
    Console.WriteLine("Sunday");
}
else

Console.WriteLine("Enter another number");