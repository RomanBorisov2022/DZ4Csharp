//       Задача 25:  Напишите цикл, который принимает на вход два числа (A и B)
//      и возводит число A в натуральную степень B.
//      3, 5 -> 243 (3⁵)
//      2, 4 -> 16
Console.Clear();
int A = UserInput1("Введите число А: ", "Ошибка ввода!");
int B = UserInput2("Введите число В: ", "Ошибка ввода!");
int exp = ExponentNumbers(A, B);
Console.WriteLine($"{A}, {B} -> {exp}");






/////////////////////////////// Обработка ввода от пользователя
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
///////////////////////////////////////////////// ВЫчисления возведения в степень
int ExponentNumbers(int A, int B)

{   
    int exp = A;                                 
    for(int i = 1; i != B; i++)
        exp = exp * A;
        
    return exp;
}