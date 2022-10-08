// Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// Метод нахождения чисел от 1 до N

int GetSumNumbers(int value)
{
    if (value == 1)
    {
        return 1;
    }
    // int result = value + GetSumNumbers(value - 1);
    // return result;
    return value + GetSumNumbers(value - 1);
}

// Метод вывода на экран чисел от 1 до N

string GetShowNumbers (int value)
{
     if (value == 1)
    {
        return "1";
    }
    string result = GetShowNumbers(value - 1) + "," + value;
    return result;
}

Console.WriteLine("Введите число(N): ");
int N = int.Parse(Console.ReadLine());
string Numbers = GetShowNumbers(N);
Console.WriteLine($"Числа в промежутке от 1 до N = {Numbers}");
int sumNumbers = GetSumNumbers(N);
Console.WriteLine($"Сумма чисел в промежутке от 1 до N = {sumNumbers}");

