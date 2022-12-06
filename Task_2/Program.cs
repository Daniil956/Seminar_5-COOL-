// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();

int[] arrey = new int[10];
int LEFTRABGE = 0;
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

Console.WriteLine("массив [" + string.Join(", ", arrey) + "]");

Console.Write("Enter numbers: ");
int number = Convert.ToInt32(Console.ReadLine());

int resalt = 0;

for(int i = 0; i < arrey.Length; i++) 
{
    if (arrey[i] == number)
    {
    resalt = 1;
    break;
    }
}   

if (resalt == 1)
{
    Console.Write("Yes");
}
else
{
    Console.Write("No");
}