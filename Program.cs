//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//
//
//entering block/////////////а
int intN1, intResult; 
//
Console.Clear();
Console.Write("Введите 3-значное число ");
intN1 = int.Parse(Console.ReadLine()!);
//
// end of entering block/////////////
//
//
//exec block
//
intResult = intN1 % 100 / 10;
Console.WriteLine($"{intResult}");
//
// end of exec block