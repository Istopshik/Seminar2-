//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
System.Console.WriteLine("Числа от 1 до 7 обозначают дни недели. Введите число и программа проверит какой из этих дней выходной");
int day = int.Parse(Console.ReadLine());
if(day <= 5)
{
    System.Console.WriteLine("Это не выходной день(");
}
else if(day == 6 || day == 7)
{
     System.Console.WriteLine("Это выходной");
}