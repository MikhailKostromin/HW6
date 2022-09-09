// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1");     
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1");     
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2");     
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2");     
double k2 = Convert.ToInt32(Console.ReadLine());


double FindX(double k1, double k2, double b1, double b2)
{
double result = 0;
result=(b1-b2)/(k2-k1);
return result;
}
double x = FindX (k1,k2,b1,b2);

double FindY1(double k1, double b1, double x)
{
double result = 0;
result=(k1*x)+b1;
return result;
}
double y1 = FindY1(k1,b1,x);

double FindY2(double k2, double b2, double x)
{
double result = 0;
result=(k2*x)+b2;
return result;
}
double y2 = FindY2(k2,b2,x);

Console.WriteLine($"Точка пересечения двух прямых ({y1}; {y2})");

