/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumNaturalElementsBetween(int firstNumber, int secondNumber)
{
    if (firstNumber < secondNumber)
    {
        return firstNumber + SumNaturalElementsBetween(firstNumber + 1, secondNumber);
    }
    if (firstNumber > secondNumber)
    {
        return secondNumber + SumNaturalElementsBetween(firstNumber, secondNumber + 1);
    }
    return firstNumber;
}

int numberM = 1;
int numberN = 15;
int result = SumNaturalElementsBetween(numberM, numberN);
Console.WriteLine($"Сумма натуральных элементов между {numberM} и {numberN} = {result}");

// M = 1; N = 15 ---> 120
// M = 15; N = 1 ---> 120