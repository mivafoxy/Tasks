// Задать массив [ 1, 5, 3, 2, 11, 4, 5, 2, 4, 8, 9, 1 ] пройти по нему циклом, и числа меньшие 6 умножить на 2;

int[] newArray = { 1, 5, 3, 2, 11, 4, 5, 2, 4, 8, 9, 1 };
void Change(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        if (newArray[i] < 6) newArray[i] = newArray[i] * 2;
    }
}
Change(newArray);



void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(newArray);