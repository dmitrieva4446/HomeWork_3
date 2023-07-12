// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

int n1 = 0;

Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int temp = n;
int rev = 0;
if (n > 9999 && n < 100000)
{
    while (n > 0)
    {
        n1 = n % 10;
        rev = rev * 10 + n1;
         n = n / 10;
    }
 if(temp == rev)
    Console.WriteLine($"Да, число {temp} является палиндромом.");
 else
    Console.WriteLine($"Нет, число {temp} НЕ является палиндромом.");
}
else
Console.WriteLine($"{n} НЕ ПЯТИЗНАЧНОЕ число!");
