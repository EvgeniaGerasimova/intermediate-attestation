//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int CalculateAckermanFunction(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (n > 0 && m == 0)
    {
        return CalculateAckermanFunction(n - 1, 1);
    }
    else
    {
        return CalculateAckermanFunction(n - 1, CalculateAckermanFunction(n, m - 1));
    }
}

Console.Write("Enter the first positive number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second positive number: ");
int m = Convert.ToInt32(Console.ReadLine());

if (n < 0 || m < 0)
{
    Console.Write("Incorrect input! Only positive numbers");
}
else
{
    Console.Write(CalculateAckermanFunction(n, m));
}



