Console.WriteLine("Введите натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());

void Cube(int n)
{
    int index = 1;
    while (index <= n)
    {
    int cube = index * index * index;
    Console.WriteLine($"{index, 5} {cube, 5}");
    index++;
    }
}

if (N > 0) Cube(N);
else Console.WriteLine("Вы ввели не натуральное число");
