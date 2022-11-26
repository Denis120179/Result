/*
Программа для первого задания

Console.WriteLine("Введите количество раундов R: ");
int R = int.Parse(Console.ReadLine()!);
Game (R);

void Game(int r)
{
    int a = 0;
    int b = 0;
    for (int count = 0; count < r; count ++) 
    {
        int X = new Random().Next(0, 11);
        Console.WriteLine("Введите число N: ");
        int N = int.Parse(Console.ReadLine()!);
        if (N == X) a = a + 1;
        else b = b + 1;            
    }
    Console.WriteLine($"Счет игры Пользователь {a} - {b} Компьютер"); 
} 
*/
