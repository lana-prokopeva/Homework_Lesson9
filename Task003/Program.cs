// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// Метод вычисления функции Аккермана с помощью рекурсии
int GetAkkermanFunction (int m, int n)
{
    if (m == 0)
    {
        return n+1;
    }
    else if (m > 0 && n == 0 )
    {
        return GetAkkermanFunction (m-1, 1);
    }
    else //(m > 0 && n > 0) 
    {
        return GetAkkermanFunction (m-1, GetAkkermanFunction(m, n - 1));
    }
    
}

// Определяем входные данные
Console.Write("Введите число(M): ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите число(N): ");
int N = int.Parse(Console.ReadLine());

if (M < 0 || N < 0) 
{
    Console.WriteLine("Функция не может быть выполнена т.к. значения M и N должны быть больше 0!");
}
else
{
    int AkkermanFunction = GetAkkermanFunction(M, N);
    Console.WriteLine($"Ответ: А({M},{N}) = {AkkermanFunction}");
}
