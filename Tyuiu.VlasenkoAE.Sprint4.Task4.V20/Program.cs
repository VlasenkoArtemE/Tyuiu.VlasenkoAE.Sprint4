using Tyuiu.VlasenkoAE.Sprint4.Task4.V20.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнил: Власенко А. Е. | ИСТНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                            *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #20                                                             *");
Console.WriteLine("* Выполнил: Власенко Артём Евгеньевич | ИСТНб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
Console.WriteLine("* значениями с клавиатуры в диапазоне от 4 до 8.                          *");
Console.WriteLine("* Заменить четные элементы массива на 1.                                  *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите количество строк в масиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов в масиве: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] mtrx = new int[rows, columns];

for (int i = 0; i < rows; i++) 
{ 
    for (int j = 0; j < columns; j++)
    {
        Console.WriteLine($"Введите {i},{j} элемент массива: ");
        mtrx[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("\nМассив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.WriteLine($"{mtrx[i, j]} \t");
    }
    Console.WriteLine();
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int[,] result = ds.Calculate(mtrx);

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{result[i, j]} \t");
    }
    Console.WriteLine();
}
Console.ReadKey();