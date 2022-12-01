
void PrintArray(string[] arr) // Метод печати
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

string[] NewArray(string [] arr) // Метод поиска элементов длиной менее 3-х символов
{
    int k = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) k++;
    }
    string[] newArr = new string[k];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr[j] = arr[i];
            j++;
        }
    }
    return newArr;
}

string[] array = { "hello", "123", "456", "hello2", "dft" };
string[] newArray = NewArray(array);
PrintArray(array);
Console.Write("-->");