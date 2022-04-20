//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
/*
int ShowNumber(int n)
{
    return((n / 10) % 10);
}

int num = new Random().Next(100, 999);
int a = ShowNumber(num);
Console.WriteLine(a);
*/
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int ShowNumber(int n)
{
    if (n <= 99)
        Console.WriteLine("Неподходящее число!");
    else
    {
        while (n > 1000)
        {
            n = n / 10;
        }
        return(n % 10);
    }
    return 0;
}

int num = Convert.ToInt32(Console.ReadLine());
int a = ShowNumber(num);
Console.WriteLine(a);
*/
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
void ShowNumber()
{
    int n = new Random().Next(1, 8);
    if (n == 6 || n == 7)
        Console.WriteLine("ДА!");
    else
        Console.WriteLine("НЕТ!");
    Console.WriteLine(n);
}

ShowNumber();