﻿Console.Clear();
string[] array1 = new string[5] {"hello", "2", "world", ":-)", "-2"};
string[] array2 = new string[array1.Length];
void ResultArrayIf(string[] array1, string[] array2)
{
    int result = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[result] = array1[i];
        result++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ResultArrayIf(array1, array2);
PrintArray(array2);