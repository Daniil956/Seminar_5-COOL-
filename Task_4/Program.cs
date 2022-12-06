// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


Console.Clear();

int[] arrey = new int[5];
int LEFTRABGE = 1;
int RAGTHRANGR = 10;

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

int multiplication = 1;

for (int i =0; i < arrey.Length / 2; i++)
{
    multiplication = arrey[i] * arrey[arrey.Length -1 -i];
    System.Console.Write($"" + multiplication + ", "); 
}

if(arrey.Length % 2 !=0)
{
    int midle = arrey[arrey.Length / 2]; 
    System.Console.WriteLine(midle );
}