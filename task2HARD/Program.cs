//задача 2 HARD необязательная. 
//Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры). 
//Вывести на экран красивенько таблицей. Перемешать случайным образом элементы массива, 
//причем чтобы каждый гарантированно один раз переместился на другое место и потом не участвовал никак 
//(возможно для этого удобно будет использование множества) и выполнить это за m*n / 2 итераций. 
//То есть если массив три на четыре, то надо выполнить не более 6 итераций. 
//И далее в конце опять вывести на экран как таблицу.

/*
задача 2 HARD необязательная. Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры). 
Вывести на экран красивенько таблицей. Перемешать случайным образом элементы массива, причем чтобы каждый гарантированно один раз 
переместился на другое место и потом не участвовал никак (возможно для этого удобно будет использование множества) и выполнить это за m*n / 2 итераций.
 То есть если массив три на четыре, то надо выполнить не более 6 итераций. И далее в конце опять вывести на экран как таблицу.
 */
void PrintArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(table[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            array[i, j] = new Random().Next(1, 100);
    }
    return array;
}

int[,] ChangeArray(int[,] table)
{
    int[,] changeArr = new int[table.GetLength(0), table.GetLength(1)];
    int[] forChange = new int[table.GetLength(0) * table.GetLength(1)];
    int[] change = new int[table.GetLength(0) * table.GetLength(1)];
    int place = 0;
    foreach (int item in table)//переводим двумерный в одномерный forchange массив
    {
        forChange[place] = item;
        place++;
    }
    int placeForChange = 0;
    for (int i = 0; i < forChange.Length/2; i++)// начинаем тасовать
    {
        IEnumerable<int> onlyInFirstSet = forChange.Except(change); // вычетаем из не тасованного масива - тасованный
        int [] array = new int [forChange.Length - i*2]; 
        place = 0;
        foreach (int item in onlyInFirstSet)//заполняем маасив результатами вычетания
        {
            array[place] = item;
            place++;
        }

        int m = 0;
        int n = 0;
        while (m == n)
        {
            m = new Random().Next(0, array.Length);//1
            n = new Random().Next(0, array.Length);//3
        }
        change[placeForChange] = array[m];//0-2-4
        change[placeForChange+1] = array[n]; //1-3-5
        placeForChange +=2; //4
    }
    if (forChange.Length%2 == 1)
    {
        IEnumerable<int> onlyInFirstSet = forChange.Except(change);
        foreach (int item in onlyInFirstSet)
        {
            change[change.Length-1] = item;
        }
    }
    place = 0;
    for (int i = 0; i < changeArr.GetLength(0); i++)
    {
        for (int j = 0; j < changeArr.GetLength(1); j++)
        {
            changeArr[i,j] = change[place];
            place++;
        }
    }
    return changeArr;
}
Console.WriteLine("Задача 1");
Console.Write("Введите количество строк двумерного массива ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество стобцов двумерного массива ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] mas = FillArray(m, n);
PrintArray(mas);
Console.WriteLine();
Console.WriteLine("Перетасованный массив");
PrintArray(ChangeArray(mas));