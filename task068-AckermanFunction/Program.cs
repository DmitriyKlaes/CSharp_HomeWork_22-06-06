/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
*/

int AckermanFunction(int firstNumber, int secondNumber)
{
    if (firstNumber == 0)
    {
        return secondNumber + 1;
    }
    if (firstNumber > 0 && secondNumber == 0)
    {
        return AckermanFunction(firstNumber - 1, 1);
    }
    return AckermanFunction(firstNumber - 1, AckermanFunction(firstNumber, secondNumber - 1));
}

int numberOne = 2;
int numberTwo = 3;
int result = AckermanFunction(numberOne, numberTwo);
Console.WriteLine(result);