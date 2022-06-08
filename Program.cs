
void PrintArray(string[] Array)            // метод печати массива
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($" {Array[i]};");
    }
}

string[] CountSymbol(string[] array) // метод вычисления длины члема массива и записи его в новый массив
{
    string[] result = new string[array.Length];
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[count] = array[i];
            count++;
        }
    }
    return result;
}

string[] ArrayString = new string[7] { "Hello", "123", "World", "kat", "85", "-9", "dog" };
string[] ArrayResult = new string[ArrayString.Length];

PrintArray(ArrayString);
ArrayResult = CountSymbol(ArrayString);
Console.WriteLine();
PrintArray(ArrayResult);
