//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
// Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.

// void Palindrome()
// {
//     Console.Write("Введите пятизначное число: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     int digit1 = number / 10000 % 10;
//     int digit2 = number / 1000 % 10;
//     int digit4 = number / 10 % 10;
//     int digit5 = number % 10;
//     int zero = number / 10000;

//     if (digit1 == digit5 && digit2 == digit4)
//     {
//         Console.WriteLine("Число является полиндромом");
//     }
//     else
//     {
//         Console.WriteLine("Число не является полиндромом");
//     }
// }
// Palindrome();

// bool isParsedNumber = int.TryParse(Console.ReadLine(), out int number);

// int CheckNumberLenght(int n)
// {
//     int count = 0;
//     while (n > 0)
//     {
//         n /= 10;
//         count++;
//     }
//     return count;
// }

// bool ShowIfNumberIsPolindrome(int n)
// {
//     int length = CheckNumberLenght(n);
//     int[] array = new int[length];
//     array[0] = n % 10;
//     int multiplicity = 1;
//     for (int i = 1; i < length; i++)
//     {
//         array[i] = (n / (10 * multiplicity)) % 10;
//         multiplicity *= 10;
//     }

//     return (true | false);
// }


// bool result = ShowIfNumberIsPolindrome(number);
// Console.WriteLine(result);


Console.WriteLine("Введите число:");
bool isParsednNumber = int.TryParse(Console.ReadLine(), out int number);
if (!isParsednNumber) 
{
    Console.WriteLine("Неверно введены данные");
    return;
}

int Palindrome(int n)
{
    int newNumber = 0;

    while (n > 0)
    {
        int excess = n % 10;

        newNumber = newNumber * 10 + excess;

        n = n / 10;
    }
    return newNumber;
}

int result = Palindrome(number);
if (result == number)
{
    Console.WriteLine("Введённое число является палиндромом");
}
else
{
Console.WriteLine("Введённое число не является палиндромом");
}     