// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// Метод вывода на экран чисел от M до N
string GetShowNumbers (int startValue, int endValue)
{
    if (startValue == endValue)
    {
        return $"{endValue}";
    }
     if (startValue > endValue)
    {
        return "значение M не может быть больше N!!!";
    }
    string result = GetShowNumbers(startValue, endValue-1) + "," + endValue;
    return result;
}

// Определяем входные данные
Console.WriteLine("Введите число(M): ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число(N): ");
int N = int.Parse(Console.ReadLine());
string Numbers = GetShowNumbers(M, N);
Console.WriteLine($"Числа в промежутке от M до N = {Numbers}");


