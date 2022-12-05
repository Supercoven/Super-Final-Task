//создание массива пользователем
string [] CreateArray()
{
    Console.WriteLine("Введите количество элементов массива: ");
    int Count = int.Parse(Console.ReadLine());

    string[] MainArray = new string[Count];
    for(int i = 0; i < MainArray.Length; i++)
    {
        Console.WriteLine($"Введите значение для {i} элемента в массиве: ");
        MainArray[i] = Console.ReadLine();
    
    }
    return MainArray;
}

//вывод введённого массива
void PrintArray(string [] MainArray)
{
     for (int i = 0; i < MainArray.Length; i++)
    {
        Console.WriteLine($"{MainArray[i], 1}");
    }
}


// создаём массив, из строк длина которых менее 3 символов
void SecondArr (string [] MainArray)
{
    string [] NewArray = new string[MainArray.Length];

    Console.WriteLine("Вывод массива в котором длина строк 3 или менее символов: ");

    Console.Write($"[");
    for(int i = 0; i < MainArray.Length; i++)
    {
        if (MainArray[i].Length <= 3)
        {
            NewArray[i] = MainArray[i];
            Console.Write($" {NewArray[i], 1} ");
        }
    }
    Console.Write($"]");
}


string [] MainArray = CreateArray();
PrintArray(MainArray);
SecondArr(MainArray);