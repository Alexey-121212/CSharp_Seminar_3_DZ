// Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.

// Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.

// Для остальных чисел вернуть True или False.

Console.WriteLine("Введите пятизначное число (от 10000 до 99999 ):");
int num = Convert.ToInt32(Console.ReadLine());

bool IsPalindrome(int number)
{
    int firstDigit = number / 10000;
    int secondDigit = (number - firstDigit * 10000) / 1000;
    int thirdDigit = (number - firstDigit * 10000 - secondDigit * 1000) / 100;
    int forthDigit = (number - firstDigit * 10000 - secondDigit * 1000 - thirdDigit * 100) / 10;
    int fifthDigit = number % 10;
    if (number>99999 | number<10000)
        Console.WriteLine("Число не пятизначное");
    if (firstDigit==fifthDigit && secondDigit==forthDigit)
    {
    return true;
    } else
    {
        return false;
    }
}

bool pAL = IsPalindrome(num);Console.WriteLine(pAL);