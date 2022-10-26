// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 
// Задание должно быть выполнено в методе и метод должен вернуть массив чисел.

Console.WriteLine("Введите число:");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedN)
{
    Console.WriteLine("Введены неверные данные");
    return; 
}

int [] TrippleTable(int N)
{
    int [] array = new int[N];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = (i+1) * (i+1) * (i+1);
    }
    return array;
}

int [] massiv = TrippleTable(n);

Console.WriteLine("Значения кубов чисел до указанного: ");
PrintArray(massiv);

void PrintArray(int [] array)
{
        for (int i = 0; i <= array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
} 