
void PrintArray(string[] arr) // Метод печати
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

string[] NewArray(string[] arr) // Метод поиска элементов длиной менее 3-х символов
{
    string[] newArr = new string[arr.Length];
    int k = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr[k] = arr[i];
            k++;
        }
    }
    string[] newArr3 = new string[k];
  
    for (int i = 0; i < k; i++)
    {
        newArr3[i] = newArr[i];
    }
    return newArr3;
}

string[] array = { "Hi", "hello", "123", "sup", "456", "hello2", "dft", "der", "sup2" };
string[] newArray = NewArray(array);
PrintArray(array);
Console.Write(" --> ");
PrintArray(newArray);