//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//
//
//entering block/////////////а
int intN1;
string strResult = "нет";
//
Console.Clear();
Console.Write("Введите одну цифру ");
intN1 = int.Parse(Console.ReadLine()!);
//
// end of entering block/////////////
//
//
//exec block
//
if (intN1 == 6 ^ intN1 == 7) 
{
    strResult = "да";
}
Console.WriteLine($"{strResult}");
//
// end of exec block