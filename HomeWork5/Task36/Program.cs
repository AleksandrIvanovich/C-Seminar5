// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Введите число от 1 до 9, которое укажет колличество элементов в массиве:");
int num = int.Parse(Console.ReadLine() ?? "");

Random rnd = new Random();
int[] arr = new int[num];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(-99, 100);
}

var result = string.Join(", ", arr);
Console.WriteLine($"[{result}]");

int sum = 0;
for (int i = 1; i < arr.Length; i = i + 2)
{
    sum = sum + arr[i];
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна: " + sum) ;
