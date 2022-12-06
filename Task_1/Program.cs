// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


Console.Clear();

int[] arrey = new int[10];
int LEFTRABGE = -100;
int RAGTHRANGR = 100;

int[] FillArrey(int leftRange,  int rigthRange)
{
    Random rand = new Random();
    for (int i = 0; i < arrey.Length; i++)
    {
        arrey[i] = rand.Next(LEFTRABGE, RAGTHRANGR);
    }
    System.Console.Write('[' + string.Join(", ", arrey) + "] -> ");
    return arrey;
}

arrey = FillArrey(LEFTRABGE, RAGTHRANGR);


for (int i = 0; i < arrey.Length; i++)
{
    arrey[i] = -arrey[i];
}
System.Console.Write('[' + string.Join(", ", arrey) + ']');
