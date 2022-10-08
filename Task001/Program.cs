// Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// Метод вывода на экран чисел от 1 до N
string GetShowNumbers (int value)
{
    if (value == 1)
    {
        return "1";
    }
     if (value <= 0)
    {
        return "Введены данные несоответствующие условиям задачи";
    }
    string result = GetShowNumbers(value - 1) + "," + value;
    return result;
}

// Определяем входные данные
Console.WriteLine("Введите число(N): ");
int N = int.Parse(Console.ReadLine());
string Numbers = GetShowNumbers(N);
Console.WriteLine($"Числа в промежутке от 1 до N = {Numbers}");

