// Задача 14: Напишите программу которое на вход принимает число и проверяет, 
// кратно ли одновременно 7 и 23
// 14-> нет;
// 161-> да. 

Console.Clear();

Console.WriteLine("print your number: ");
int num = int.Parse(Console.ReadLine()!);

if (num % 7 == 0 && num % 23 == 0)
{
    Console.Write("{yes}");
}
else
{
    Console.Write("{no}");
}