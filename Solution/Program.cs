/*Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3. Первоначальный массив можно ввести с клавиатуры, либо
задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.*/

int InputInt(string message)
{
    System.Console.WriteLine(message + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

string[] InputArray(int number)
{
    string[] array = new string[number];
    for (int i = 0; i < number; i++)
    {
        System.Console.WriteLine($"Введите {i + 1}й элемент. После ввода числа нажмите клавишу Enter.");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

void PrintArray(string[] array)
{
    System.Console.WriteLine(string.Join(",", array));
}

string[] LessThreeSymbolsArray(string[] array)
{
    int count = 0;
    string[] arr = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
            Array.Resize(ref arr, count);
            arr[count - 1] = array[i];
        }
    }
    return arr;
}

int countElements = InputInt("Введите количество элементов");
string[] array = InputArray(countElements);
string[] resultArray = LessThreeSymbolsArray(array);
PrintArray(resultArray);