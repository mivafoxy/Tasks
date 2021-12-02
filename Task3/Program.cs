// Задать пустой целочисленный массив длиной 100. С помощью цикла заполнить его значениями 1 2 3 4 5 6 7 8 … 100;

int[] newArray = new int [100];
int result = 0;
int count = 100;
for (int i = 0; i < count; i++)
{
    result = result + 1;
    Console.Write(result + " ");
}