//Найти расстояние между точками в пространстве 2D/3D

Console.WriteLine("Программа поиска расстояние между точками в пространстве 2D/3D");

Console.WriteLine("Нужно указать только цифру от 2D или 3D");
int n1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Загрузка..");


if(n1 == 2)
{
    Console.Write("Укажите координату х1: ");
    int x1 = int.Parse(Console.ReadLine()!);
    Console.Write("Укажите координату у1: ");
    int y1 = int.Parse(Console.ReadLine()!);
    Console.Write("Укажите координату х2: ");
    int x2 = int.Parse(Console.ReadLine()!);
    Console.Write("Укажите координату у2: ");
    int y2 = int.Parse(Console.ReadLine()!);

    double d1 = 2;

    Console.WriteLine("Расстояние между точками: ", d1);

}

else if(n1 == 3)
{
    Console.Write("Укажите координату х1: ");
    int x1 = int.Parse(Console.ReadLine()!);
    Console.Write("Укажите координату у1: ");
    int y1 = int.Parse(Console.ReadLine()!);
    Console.Write("Укажите координату z1: ");
    int z1 = int.Parse(Console.ReadLine()!);
    Console.Write("Укажите координату х2: ");
    int x2 = int.Parse(Console.ReadLine()!);
    Console.Write("Укажите координату у2: ");
    int y2 = int.Parse(Console.ReadLine()!);
    Console.Write("Укажите координату z2: ");
    int z2 = int.Parse(Console.ReadLine()!);

    double d1 = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - x1)) + ((z2 - z1) * (z2 - z1)));
    Console.WriteLine("Расстояние между точками: ", d1);

}
