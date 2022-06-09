/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 5; N = 1. -> "5, 4, 3, 2, 1"
M = 8; N = 4. -> "8, 7,6, 5, 4"
*/

string NaturalNumbersFromTo(int firstNumber, int secondNumber)
{
    if (firstNumber < secondNumber)
    {
        return $"{firstNumber}, " + NaturalNumbersFromTo(firstNumber + 1, secondNumber);
    }
    if (firstNumber > secondNumber)
    {
        return NaturalNumbersFromTo(firstNumber, secondNumber + 1) + $", {secondNumber}";
    }
    return $"{firstNumber}";    
}

int numberM = 4;
int numberN = 8;
Console.WriteLine(NaturalNumbersFromTo(numberM, numberN));

// M < N ---> M, M + 1, M + 2, ... , N
// M > N ---> M, ... , N + 2, N + 1, N
// M = N ---> M