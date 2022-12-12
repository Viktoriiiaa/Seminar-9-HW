//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

/*
string RecNumb(int N, int b)
{
    if (N >= b) return $"{N} " + RecNumb(N - 1, b);
    else return string.Empty;
}
Console.Write("Задайте значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(RecNumb(N, 1));
*/

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
Console.Write("Задайте значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
int RecSum(int n)
{
    if (m > n) return 0;
    else return n + RecSum(n - 1);
}

Console.WriteLine("Сумма натуральных элементов в промежутке от " + m + " до " + n + " = " + RecSum(n));
*/  

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 

/*
Console.Write("Введите неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m >= 4 || n > 10) Console.WriteLine("Программа не предназначена для вычисления таких больших значений, уменьшите значение переменных");
else
{
    int Akkerman(int n, int m)
    {

        if (n == 0) return (m + 1);
        else if (n != 0 && m == 0) return Akkerman(n - 1, 1);
        else if (n > 0 && m > 0) return Akkerman(n - 1, Akkerman(n, m - 1));

        return Akkerman(m, n);
    }
    Console.WriteLine(Akkerman(m, n));
}
*/ 