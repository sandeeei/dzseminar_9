// Задача 68: Напишите программу вычисления функции Аккермана
//  с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число в диапазоне то 0 до 3 включительно: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число в диапазоне то 0 до 5 включительно: ");
int n = Convert.ToInt32(Console.ReadLine());

int CalFunction(int num1, int num2)
{
    if (num1 == 0) return (num2 + 1);
    if (num2 == 0) return CalFunction( num1 - 1, 1);
    return CalFunction( num1 - 1, CalFunction( num1 , num1-1));

}
Console.WriteLine(CalFunction(m,n));