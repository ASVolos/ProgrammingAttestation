/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
void SeriesOfNaturalNumbers(int n)
{
    if (n > 0)
    {
        Console.Write(n + " ");
        SeriesOfNaturalNumbers(n - 1);
    }
}
Console.Write("Imput numbers N: ");
int n = Convert.ToInt32(Console.ReadLine());
SeriesOfNaturalNumbers(n);


/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int SumOfNaturalNumbers(int m, int n)
{

    if (n >= m)
    {
        return m + SumOfNaturalNumbers(m + 1, n);
    }
    else 
    {
        return 0;
    }
}

Console.Write("Imput numbers m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput numbers n: ");
int n = Convert.ToInt32(Console.ReadLine());

int sum = SumOfNaturalNumbers(m, n);
Console.WriteLine(sum);


/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
int AckermanFunction(int m, int n)

{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return AckermanFunction(m - 1, 1);
    if (m > 0 && n > 0) return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
return AckermanFunction(m, n);
}

Console.Write("Imput numbers m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput numbers n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(AckermanFunction(m, n));
