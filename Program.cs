int InputNumber(string str) // Проверка корректности введенных данных
{
    int number;
    string? text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Вы ввели не число");
    }
    return number;
}

string[] FillRandomArray(int size) // Заполнение пользователем одномерного массива заданного размера.
{
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"Введите {i + 1} эллемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] NewStringArray(string[] array, int left, int right) // Заполнение нового массива рандомными элементами заданного массива.
{
    Random rand = new Random();
    int random_size = rand.Next(left, right);
    string[] new_array = new string[random_size];
    for (int i = 0; i<new_array.Length; i++)
    {
        new_array[i] = array[new Random().Next(0, array.Length)];
    }
    return new_array;
}

