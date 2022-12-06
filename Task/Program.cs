// Задача: 
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равно 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись ислкютительно массивыми.
// Пример:
// ["hello","2","world",":-)"] -> ["2", ":-)"]
// ["1234","1567","-2","computer science"] -> ["-2"]
// ["Russia", "Denmark","Kazan"]` -> []


string ?[] CreateArray(int size) // Метод создания массива, при вводе элементов с клавиатуры
{
    string?[] arr = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите слово: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void PrintArray(string?[] arr) // Метод печати массива
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write(" ]");
}

// string[] NewArray(string[] arr) // Метод поиска элементов длиной менее 3-х символов
// {
//     int k = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i].Length <= 3) k++;
//     }
//     string[] newArr = new string[k];
//     int j = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i].Length <= 3)
//         {
//             newArr[j] = arr[i];
//             j++;
//         }
//     }
//     return newArr;
// }

// string[] array = { "hello", "123", "456", "hello2", "dft", "der" };
// string[] newArray = NewArray(array);
// PrintArray(array);
// Console.Write("-->");
// PrintArray(newArray);

string?[] NewArray(string?[] arr) // Метод поиска элементов длиной менее 3-х символов
{
    string?[] newArr = new string[arr.Length];
    int k = 0;
    for (int i = 0; i < arr?.Length; i++)
    {
        if (arr[i]?.Length <= 3 && arr[i]?.Length > 0)
        {
            newArr[k] = arr[i];
            k++;
        }
    }
    string?[] newArr3 = new string[k];

    for (int i = 0; i < k; i++)
    {
        newArr3[i] = newArr[i];
    }
    return newArr3;
}

Console.Write("Введите челое положительное число - размер создаваемого массива: ");
int num = Convert.ToInt32(Console.ReadLine());

string?[] array = CreateArray(num);
string?[] newArray = NewArray(array);

PrintArray(array);
Console.Write(" --> ");
PrintArray(newArray);