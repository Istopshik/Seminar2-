//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
System.Console.WriteLine("Введите любое число");
string number = Console.ReadLine();
int number1 = Convert.ToInt32(number);
if(number1 <= 99)
{
    System.Console.WriteLine("Третьей цифры нет!");
}
else
{
     System.Console.WriteLine($"Третья цифра заданного числа {number[2]}");
}


