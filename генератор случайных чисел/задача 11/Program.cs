// / Задача 11: Напишите программу, кторая выводит случайное трехзначное число и удаляет вторую цифру.
// 456->46

Console.Clear();

int num = new Random().Next(10, 999);

 Console.WriteLine(num);

int a1 = num / 100;

int a2 = num % 10;

int res = a1 * 10 + a2;

 Console.WriteLine($"{res}");