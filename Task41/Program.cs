// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void CountPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) count++;
    Console.WriteLine($"Колличество чисел больше 0 - {count}");
}

int[] FillArray(int length)
{
    int[] filledArray = new int[length];
    for (int i = 0; i < filledArray.Length; i++)
    {
        filledArray[i] = GetImput($"Введите {i + 1} число: ");
    }
    return filledArray;
}

int GetImput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int size = GetImput("Введите колличество чисел: ");
int[] array = FillArray(size);
Console.WriteLine($"[{String.Join(", ", array)}]");
CountPositive(array);