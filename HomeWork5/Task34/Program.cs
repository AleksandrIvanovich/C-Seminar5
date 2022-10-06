//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.


Random rnd = new Random();
int[] arr = new int[4];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(100, 1000);
}

var result = string.Join(", ", arr);
Console.WriteLine($"[{result}]");

int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i]%2 == 0)
    count++;

}
Console.WriteLine($"Количество четных чисел в данном массиве: {count}");
