// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.

Console.WriteLine("Введите координаты первой точки: ");
bool isParsedX1 = int.TryParse(Console.ReadLine(), out int x1);
bool isParsedY1 = int.TryParse(Console.ReadLine(), out int y1);
bool isParsedZ1 = int.TryParse(Console.ReadLine(), out int z1);
Console.WriteLine("Введите координаты второй точки: ");
bool isParsedX2 = int.TryParse(Console.ReadLine(), out int x2);
bool isParsedY2 = int.TryParse(Console.ReadLine(), out int y2);
bool isParsedZ2 = int.TryParse(Console.ReadLine(), out int z2);

if (!isParsedX1 || !isParsedX2 || !isParsedY1 || !isParsedY2 || !isParsedZ1 || !isParsedZ2)
{
    Console.WriteLine("Введены неверные данные");
    return;
}

double DistanceBetweenDots(int xx1, int yy1, int zz1, int xx2, int yy2, int zz2)
{
    double distance = Math.Sqrt((xx2 - xx1) * (xx2 - xx1) + (yy2 - yy1) * (yy2 - yy1) + (zz2 - zz1) * (zz2 - zz1));
    return distance;
}

double result = DistanceBetweenDots(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками в 3D пространстве: {result}");