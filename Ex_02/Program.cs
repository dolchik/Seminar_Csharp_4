// Задача 26: Напишите программу, которая принимает на вход число 
//и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int EntryDigit(string str) // пользователь вводит число и мы его считываем
{
Console.Write(str);
int number = int.Parse(Console.ReadLine());
return number;
}

int CountDigits(int number)
{
    int i;
    for (i = 0; number > 0; i++)
    {
        number = number / 10;
    }
    return i;
}

int numb = EntryDigit("Введите число: ");
int result = CountDigits(numb);
Console.WriteLine($"{numb} -> {result}");
