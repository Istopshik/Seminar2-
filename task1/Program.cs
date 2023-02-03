//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
System.Console.WriteLine("Введите трахзначное число");
int number = int.Parse(Console.ReadLine());
if(number <= 99 || number >= 1000)  
{
    System.Console.WriteLine("Вы ввели не трехзначное число!");
}
else
{
    int number1 = number%100;
    int number2 = number1/10;
    System.Console.WriteLine($"Вторая цифра из вашего числа: {number2}");
}



