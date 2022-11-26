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

/*
Программа для второго задания

string[] array = GetArray();
PrintArray(array);
PrintArray2(array);

string[] GetArray()
{ 
    string[] result = new string[5];
    for (int i = 0; i < 5; i++)
    {        
        Console.WriteLine("Введите строку массива:");
        result[i] = Console.ReadLine()!;
    }
    return result;
}

void PrintArray(string[] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {        
        Console.Write($"{Array[i]}  ");            
    }
    Console.WriteLine();
}

void PrintArray2(string[] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        int L = Array[i].Length;
        if (L <= 3) 
        Console.Write($"{Array[i]}  ");        
    }
    Console.WriteLine();
}
*/