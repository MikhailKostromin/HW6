// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите любое количество чисел через пробел: ");
string arrayNumber = Console.ReadLine();
var array = arrayNumber.Split(' ').Select(Int32.Parse).ToArray();
Console.WriteLine ($"Список чисел [{arrayNumber}]");
int count =0;
for (int i = 0; i < array.Length; i++)
{
    
    if (array[i]>0)
    {
        count=count+1;
    }
    
}
Console.WriteLine ($" Чисел больше 0 = [{count}]");
// void PrintArray (int[] array) //Красиво печатаем массив
// {
// Console.Write("[");                     
// for (int i = 0; i < N - 1; ++i)
// {
//     Console.Write(array[i] + ", ");
// }
// Console.WriteLine(array[N - 1] + "]");
// }
// PrintArray(array);