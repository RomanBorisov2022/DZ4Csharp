// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

int A = UserInput1("Введите 1е число: ", "Ошибка ввода!");
int B = UserInput2("Введите 2е число: ", "Ошибка ввода!");
int C = UserInput3("Введите 3е число: ", "Ошибка ввода!");
int D = UserInput4("Введите 4е число: ", "Ошибка ввода!");
int E = UserInput5("Введите 5е число: ", "Ошибка ввода!");
int F = UserInput6("Введите 6е число: ", "Ошибка ввода!");
int G = UserInput7("Введите 7е число: ", "Ошибка ввода!");
int I = UserInput8("Введите 8е число: ", "Ошибка ввода!");


Console.Write($"{A}, {B}, {C}, {D}, {E}, {F}, {G}, {I} -> ");
Console.Write($"[{A}, {B}, {C}, {D}, {E}, {F}, {G}, {I}]");






//////////////////////////////////////////////////////////////////
int UserInput1(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out int A))
            return A;

        Console.WriteLine(errorMessage);
    }
}
int UserInput2(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out int B))
            return B;

        Console.WriteLine(errorMessage);
    }
}
int UserInput3(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out int C))
            return C;

        Console.WriteLine(errorMessage);
    }
}
int UserInput4(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out int D))
            return D;

        Console.WriteLine(errorMessage);
    }
}
int UserInput5(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out int E))
            return E;

        Console.WriteLine(errorMessage);
    }
}
int UserInput6(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out int F))
            return F;

        Console.WriteLine(errorMessage);
    }
}
int UserInput7(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out int G))
            return G;

        Console.WriteLine(errorMessage);
    }
}
int UserInput8(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out int I))
            return I;

        Console.WriteLine(errorMessage);
    }
}