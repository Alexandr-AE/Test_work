// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


int Input(string message)
{
    System.Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
string InputString(string message)
{
    System.Console.Write(message);
    string str = Console.ReadLine()!;
    return str;
}
void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = InputString($"Введите {i + 1} значение: ");
    }
}
void PrintArray(string[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            System.Console.Write($"“{array[i]}”, ");
        else System.Console.Write($"“{array[i]}”");
    }
    System.Console.WriteLine("]");
}
int NewArraySize(string[] array, int sizeFilter)
{
    int newSize = 0;
    foreach (string item in array)
    {
        if (item.Length < sizeFilter)
            newSize++;
    }
    return newSize;
}
void ArrayFilter(string[] array, string[] newArray, int sizeFilter)
{
    int i = 0;
    foreach (string item in array)
    {
        if (item.Length < sizeFilter)
        {
            newArray[i] = item;
            i++;
        }
    }
}

int size = Input("Укажите количество строковых значений массива: ");
string[] array = new string[size];
FillArray(array);
PrintArray(array);
int sizeFilter = 1 + Input("Введите количество символов, значения массива, первышаюшие эту длину, будут удалены: ");
string[] newArray = new string[NewArraySize(array, sizeFilter)];
ArrayFilter(array, newArray, sizeFilter);
PrintArray(newArray);