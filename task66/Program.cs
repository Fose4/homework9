// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите целое положительное число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите целое положительное число N: ");
int n = int.Parse(Console.ReadLine());

int SumNumbersRange(int numFIrst, int numSecond)
{
    int sum = 0;
    if (numFIrst > numSecond)
    {
        int tmp = numFIrst;
        numFIrst = numSecond;
        numSecond = tmp;
    }
    if (numFIrst == numSecond) return sum += numSecond;
    return sum += numFIrst + SumNumbersRange(numFIrst + 1, numSecond);
}

int sumNumbersRange = SumNumbersRange(m, n);

Console.WriteLine($"M = {m}; N = {n} -> {sumNumbersRange}");