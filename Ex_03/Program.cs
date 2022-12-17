// Задача 28: Напишите программу, которая принимает на вход число N 
//и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int EntryDigit(string str) // пользователь вводит число и мы его считываем
{
Console.Write(str);
int number = int.Parse(Console.ReadLine());
return number;
}

int MultiplyDigits(int N) //метод перемножает все числа от 1 до N
{
    int Multiply = 1;
    for (int i = 1; i <= N; i++)
    {
        Multiply = Multiply * i;
    }
    return Multiply;
}

int numb = EntryDigit("Введите число: ");
int result = MultiplyDigits(numb);
Console.WriteLine($"{numb} -> {result}");