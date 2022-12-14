// Задача 24: Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Clear();
// получить число от пользователя
int EntryDigit(string str)
{
    Console.Write(str);
    int numb = int.Parse(Console.ReadLine());
    return numb;
}
// пишем цикл от 1 до А
// суммируем каждый итератор

int FindSum(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
       sum = sum + i; 
    }
    return sum;
}

int number = EntryDigit("Введите число: ");

int result = FindSum(number);
Console.WriteLine("Сумма всех чисел до А = " +result);
