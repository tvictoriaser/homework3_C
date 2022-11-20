Console.WriteLine("Введите координаты первой точки");
Console.Write("Введите значение x1 ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение y1 ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение z1 ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("Введите значение x1 ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение y1 ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение z1 ");
double z2 = Convert.ToDouble(Console.ReadLine());

double Distance(double xa1, double ya1, double za1, double xb2, double yb2, double zb2)
{
    return Math.Sqrt(((xb2 - xa1)*(xb2 - xa1)) + ((yb2 - ya1)*(yb2 - ya1)) + ((zb2 - za1)*(zb2 - za1)));
}

double distance = Math.Round(Distance(x1, y1, z1, x2, y2, z2), 2, MidpointRounding.ToZero);
Console.WriteLine(distance);