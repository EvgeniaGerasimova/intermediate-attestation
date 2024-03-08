// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void OutputOfNaturalNumbers(int M, int N)
{
    if (N == M - 1)
    {
        return;
    }
    OutputOfNaturalNumbers(M, N - 1);
    Console.Write(N + " ");
}
Console.Write("Enter the minimum number: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the maximum number: ");
int N = Convert.ToInt32(Console.ReadLine());
OutputOfNaturalNumbers(M, N);