//Задача 13: Напишите программу, которая выводит третью цифру (справа налево) заданного числа или сообщает, что третьей цифры нет.
//
//
//entering block/////////////а
int intN1, intResult; 
//
Console.Clear();
Console.Write("Введите число ");
intN1 = int.Parse(Console.ReadLine()!);
//
// end of entering block/////////////
//
//
//exec block
//
if (intN1>=100)
{
    intResult = intN1 % 10;
    Console.WriteLine($"{intResult}");
}else
{
Console.WriteLine($"Нет 3-й цифры");
}
//
// end of exec block