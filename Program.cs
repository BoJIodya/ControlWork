
void PrintArray (string[] Array)            // метод печати массива
{
    for (int i = 0; i< Array.Length; i++)
    {
        Console.Write($" {Array[i]};");
    }
}



string[] ArrayString = new string[7] {"Hello", "123", "World", "kat", "85", "-9", "dog"};
string[] ArrayResult = new string[ArrayString.Length];
PrintArray(ArrayString);