/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]

все 8 элементов должны получить за один Console.ReadLine();
подсказка: использовать потом метод string.Split(); */

string GetMas(string message)
{
    Console.WriteLine(message);
    string result = Console.ReadLine();
    return result;
}

//метод для печати массива
void PrintArray(string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i!=array.Length-1)
        {
            Console.Write(@", ");        
        }
        else
        {
            break;    
        }
    }
    Console.WriteLine();
}

string massive = GetMas ("введите 8 чисел через запятую");
massive = massive.Replace(" ", "");
string[] array = massive.Split(',');

PrintArray(array);

