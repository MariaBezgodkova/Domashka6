//Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1,    y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// 
Console.WriteLine ("Для уравнения y = k1 * x + b1 задайте значения:");
Console.Write("Задайте k1  :  ");
var k1 =Convert.ToDouble(Console.ReadLine());
Console.Write("Задайте b1:  ");
var b1 = Convert.ToDouble(Console.ReadLine());
// 
Console.WriteLine ("Для уравнения y = k2 * x + b2 задайте значения:");
Console.Write("Задайте k2:  ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Задайте b2:  ");
var b2 = Convert.ToDouble(Console.ReadLine());

// поиск y и x
var x = (b2-b1)/(k1-k2);

var y = k1*x+b1;
Console.WriteLine($"Точка пересечения двух прямых: {x} ;  {y} ");