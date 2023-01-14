/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

  int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("ввели не число");
        }
    }

    return result;
}

int number1 = GetNumber("Введите первое число");
int number2 = GetNumber("Введите второе число");

Console.WriteLine(Math.Pow(number1, number2));
