using Tyuiu.VlasenkoAE.Sprint4.Task5.V26.Lib;

DataService ds = new DataService();
Random rnd = new Random();

Console.Title = "Спринт #4 | Выполнил: Власенко А. Е. | ИСТНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы (генератор случайных чисел)                     *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #26                                                             *");
Console.WriteLine("* Выполнил: Власенко Артём Евгеньевич | ИСТНб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
Console.WriteLine("* случайными значениями в диапазоне от -4 до 4.                           *");
Console.WriteLine("* Заменить положительные элементы на 1.                                  *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите количество строк в масиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов в масиве: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] mtrx = new int[rows, columns];

Console.WriteLine("***************************************************************************");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        mtrx[i, j] = rnd.Next(-4, 4);
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