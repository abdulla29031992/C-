Console.Clear();

Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine()!);
CheckPalindromicNumber(number);

void CheckPalindromicNumber(int number)
{
    if (number > 10000)
    {
        int div1 = number / 100000;
        int rem1 = number % 10;

        if (div1 == rem1)

        number = number % 10;
        
        int div2 = (number / 100) % 10;
        int rem2 = number % 10;

        if (div2 == rem2)
        {
            Console.WriteLine("yes")
        }
    }

   
}