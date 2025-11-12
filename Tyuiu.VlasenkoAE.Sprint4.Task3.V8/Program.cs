using Tyuiu.VlasenkoAE.Sprint4.Task3.V8.Lib;

DataService ds  = new DataService();

Console.Title = "Спринт #4 | Выполнил: Власенко А. Е. | ИСТНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнил: Власенко Артём Евгеньевич | ИСТНб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
Console.WriteLine("* статическими значениями в диапазоне от 2 до 8.                          *");
Console.WriteLine("* Найдите минимальный элемент в четвертом столбце массива.                *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[,] array = new int[5, 5]{ { 4, 8, 3, 4, 8 },
                                          { 5, 3, 5, 7, 8 },
                                          { 3, 7, 2, 7, 7 },
                                          { 5, 2, 4, 6, 4 },
                                          { 4, 4, 6, 7, 2 }, };

int rows = array.GetUpperBound(0) + 1;   // количество строк
int columns = array.Length / rows;       // количество столбцов или int columns = array.GetUpperBound(1) + 1;

Console.WriteLine("Массив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.WriteLine($"{array[i, j]} \t");
    }
}

Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Минимальный элемент в четвертом столбце массива: " + ds.Calculate(array));

Console.ReadKey();