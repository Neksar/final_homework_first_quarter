# Итоговая проверочная работа.

## Условие задачи.
        Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
        При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

### Метод инициализация проверки корректности введенных данных

    int InputNumber(string str){
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

В данном методе происходит проверка корректности введенных данных.
Если пользователь ввел не число, то дальнейшее выполнение алгоритма будет невозможно до тех пор, пока пользователь не введет необходимый тип данных.

### Метод заполнения пользователем одномерного массива

    string[] FillRandomArray(int size)
    {
        string[] array = new string[size];
        for (int i = 0; i < array.Length; i++)
        {
            System.Console.Write($"Введите {i + 1} эллемент массива: ");
            array[i] = Console.ReadLine();
        }
        return array;
    }

В данном методе происходит заполнение пользователем одномерного массива заданной длины с клавиатуры.

### Метод заполнения массива случайными элементами другого массива.

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

Данный метод создает новый одномерный массив, необходимой длины и заполняет его элементами ранее заданного массива.

### Метод вывода результатов на экран

    void PrintArray(string[] array)
    {
        Console.WriteLine("[" + string.Join(", ", array) + "]");
    }
    System.Console.WriteLine();

Данный метод выводит полученные результаты на экран.