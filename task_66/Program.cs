// Задача 66: Задайте значения M и N.
//  Напишите программу, которая найдёт сумму натуральных элементов
//   в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите меньшее число: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите большее число: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num1, int num2)
 {
    

     if (num1>num2) return 0;
     
     
     if (num1==num2) return num2;
     
     return (num1 + SumNumbers(num1+1,num2));
 }
 Console.WriteLine(SumNumbers(M,N));