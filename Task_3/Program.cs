// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Clear();

int[] arrey = new int[123];
int LEFTRABGE = 0;
int RAGTHRANGR = 500;

int[] FillArrey(int leftRange,  int rigthRange)
{
    Random rand = new Random();
    for (int i = 0; i < arrey.Length; i++)
    {
        arrey[i] = rand.Next(LEFTRABGE, RAGTHRANGR);
    }
    return arrey;
}

arrey = FillArrey(LEFTRABGE, RAGTHRANGR);

Console.Write("массив [" + string.Join(", ", arrey) + "] -> ");

int sumNumbers = 0;

for (int i = 0; i < arrey.Length; i++)
{
    if (arrey[i] > 10 && arrey[i]< 99)
    {
        sumNumbers +=1; 
    }
}
System.Console.WriteLine(sumNumbers);
