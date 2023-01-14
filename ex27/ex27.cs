/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

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

 int GetSumm(string num)
{
    int summ = 0;

    for (int i = 0; i <= num.Length-1; i++)
    {
        int B = Convert.ToInt32(num[i]);
        B -= 48;
        summ += B;
    }

    return summ;
}


int number = GetNumber("Введите число");
string num = number.ToString();
int rez = GetSumm(num);
Console.WriteLine(rez);

