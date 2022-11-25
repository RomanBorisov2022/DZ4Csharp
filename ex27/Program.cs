// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int userInput = UserInput("Введите целое число до 5-ти знаков: ", "Ошибка ввода! Необходимо число.");
int sum = Sum(userInput);

Console.WriteLine($"{userInput} -> {sum}");


/////////////////////////////////////////////////////////////////////////////////////
int UserInput(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out int userInput))
            return userInput;

        Console.WriteLine(errorMessage);
    }
}
/////////////////////////////////////////////////////////////////////////////////////
int Sum(int userInput)
{   
    int a = userInput / 10000;
    int b = userInput % 10000;
    int c = b / 1000;
    int d = b % 1000;
    int e = d / 100;
    int f = d % 100;
    int g = f / 10;
    int i = f % 10;

    int sumNumbers = a + c + e + g + i;
    return sumNumbers;
}
