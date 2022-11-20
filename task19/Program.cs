Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Palindrome (int n)
{
    return n / 10000 == n % 10 && n / 1000 % 10 == n / 10 % 10;
}

if (number > 9999 && number < 100000)
{
    bool result = Palindrome(number);
    Console.WriteLine(result ? "Да" : "Нет");
}
else Console.WriteLine("Вы ввели неверное число");

