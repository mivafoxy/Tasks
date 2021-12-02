// Задать целочисленный массив, 
//состоящий из элементов 0 и 1. 
//Например: [ 1, 1, 0, 0, 1, 0, 1, 1, 0, 0 ]. С помощью цикла и условия заменить 0 на 1, 1 на 0;

int[] newArray = { 1, 0, 1, 0, 1, 0, 0, 0 };
void Change(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        if (newArray[i] == 0) newArray[i] = 1;
        else newArray[i] = 0;
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