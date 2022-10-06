// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите число от 1 до 9, которое укажет колличество элементов в массиве:");
int num = int.Parse(Console.ReadLine() ?? "");

Random rnd = new Random();
int[] arr = new int[num];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 10);
}
var result = string.Join(", ", arr);
Console.WriteLine($"[{result}]");


int size = arr.Length;

int numMin = int.MaxValue;
int FindMin()
{
    for (int j = 0;j < size; j++)
     {
        if (arr[j] < numMin)
            numMin = arr[j];
     }  
    return numMin;
}
int numMax = int.MinValue;
int FindMax() 
{
    for (int i = 0; i < size; i ++)
    {
        if (arr[i] > numMax)
            numMax = arr[i];
    }      
    return numMax;
} 

int numberMax = FindMax();
int numberMin = FindMin();

int difference = numberMax - numberMin;
Console.WriteLine($"Разницу между максимальным элементом {numberMax} и минимальным элементом {numberMin} массива равна: {difference}");