// задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа.
// Определить , является ли это сторонами треугольника. 
//Если да, то вывести всю информацию по нему - площадь, периметр, 
//значения углов треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.

Console.WriteLine("Введите сторону А ");     
double a = Convert.ToInt32(Console.ReadLine());     
Console.WriteLine("Введите сторону B ");     
double b = Convert.ToInt32(Console.ReadLine());     
Console.WriteLine("Введите сторону C ");     
double c = Convert.ToInt32(Console.ReadLine()); 

string CheckTriangle() 
{     
    string result = "";
         
    if (a < b+c && b < a+c && c < a+b)     
    {         
        result = "Треугольник сущетвует ";
        double PerimeterTriangle() // Вычисление Периметра треугольника
{
    double result =0;
    result=a+b+c;
    return result;
}
double P=PerimeterTriangle();

double SquareTriangle() // Вычисление Площади треугольника
{
    double result =0;
    double p=P/2; // Полупериметр
    result= Convert.ToDouble (Math.Round(Math.Sqrt(p*(p-a)*(p-b)*(p-c)), 2)); //Math.Pow-возведение в степень, Math.Sqrt(Double)- возвращает корнь из указанного числа, Math.Round-Округляет значение до ближайшего целого или указанного количества десятичных знаков.
    return result;
}
double S=SquareTriangle();

void FindCorners() //Поиск значений углов треугольника в градусах Через Match.Acos
{
   
   double alfa = Math.Round((Math.Acos ((a * a + c * c - b * b) / (2 * a * c))* 180 / Math.PI) , 2);
   double beta = Math.Round((Math.Acos ((a * a + b * b - c * c) / (2 * a * b))* 180 / Math.PI) , 2);
   double gamma = Math.Round((Math.Acos ((b * b + c * c - a * a) / (2 * c * b))* 180 / Math.PI) , 2);
   Console.WriteLine($"Угол альфа равен = {alfa}С, Угол бета равен = {beta}С, Угол гамма равен = {gamma}С");
//    double result = 0;
//    return result;
 if (a==b && b==c) //Определение формы треугольника
    {
        Console.WriteLine("Треугольник равностороний или правильный");
    }
    else if (a==b || b==c || c==a)
    {
        if (alfa==90 || beta==90 ||gamma==90)
        {
            Console.WriteLine("Треугольник прямоугольный и равнобеднный");
        }
        else Console.WriteLine("Треугольник равнобеднный");
    }
    else Console.WriteLine("Разностороний");

}
FindCorners();

Console.WriteLine ($"Его площадь S = {S}, Периметр P = {P}, ");
             
    }     
    else 
    {
        result = "Треугольник НЕ сущетвует";
    }     
    return result; 
} 
Console.WriteLine(CheckTriangle());

// double PerimeterTriangle() // Вычисление Периметра треугольника
// {
//     double result =0;
//     result=a+b+c;
//     return result;
// }
// double P=PerimeterTriangle();

// double SquareTriangle() // Вычисление Площади треугольника
// {
//     double result =0;
//     double p=P/2; // Полупериметр
//     result= Convert.ToDouble (Math.Round(Math.Sqrt(p*(p-a)*(p-b)*(p-c)), 2)); //Math.Pow-возведение в степень, Math.Sqrt(Double)- возвращает корнь из указанного числа, Math.Round-Округляет значение до ближайшего целого или указанного количества десятичных знаков.
//     return result;
// }
// double S=SquareTriangle();

// void FindCorners() //Поиск значений углов треугольника в градусах Через Match.Acos
// {
   
//    double alfa = Math.Round((Math.Acos ((a * a + c * c - b * b) / (2 * a * c))* 180 / Math.PI) , 2);
//    double beta = Math.Round((Math.Acos ((a * a + b * b - c * c) / (2 * a * b))* 180 / Math.PI) , 2);
//    double gamma = Math.Round((Math.Acos ((b * b + c * c - a * a) / (2 * c * b))* 180 / Math.PI) , 2);
//    Console.WriteLine($"Угол альфа равен = {alfa}С, Угол бета равен = {beta}С, Угол гамма равен = {gamma}С");
// //    double result = 0;
// //    return result;
//  if (a==b && b==c) //Определение формы треугольника
//     {
//         Console.WriteLine("Треугольник равностороний или правильный");
//     }
//     else if (a==b || b==c || c==a)
//     {
//         if (alfa==90 || beta==90 ||gamma==90)
//         {
//             Console.WriteLine("Треугольник прямоугольный и равнобеднный");
//         }
//         else Console.WriteLine("Треугольник равнобеднный");
//     }
//     else Console.WriteLine("Разностороний");

// }
// FindCorners();

// Console.WriteLine ($"Его площадь S = {S}, Периметр P = {P}, ");

// void FormTriangle(double alfa,double beta, double gamma) // Определение формы треугольника
// {
//     if (a==b && b==c)
//     {
//         Console.WriteLine("Треугольник равностороний или правильный");
//     }
//     else if (a==b || b==c || c==a)
//     {
//         if (alfa==90 || beta==90 ||gamma==90)
//         {
//             Console.WriteLine("Треугольник прямоугольный и равнобеднный");
//         }
//         else Console.WriteLine("Треугольник равнобеднный");
//     }
//     else Console.WriteLine("Разностороний");
    
//     // double result =0;
//     // return result;
// }
// FormTriangle();







// Когда b2 + c2 - a2 > 0, угол α будет острым.
// Когда b2 + c2 - a2 = 0, угол α будет прямым.
// Когда b2 + c2 - a2 < 0, угол α будет тупым.