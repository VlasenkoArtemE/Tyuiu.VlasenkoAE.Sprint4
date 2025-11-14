using Tyuiu.VlasenkoAE.Sprint4.Task7.V10.Lib;

int rows = 3;
int columns = 4;
int[,] mtrx = new int[rows, columns];
string str = "695847142536";

DataService ds  = new DataService();

Console.Title = "Спринт #4 | Выполнил: Власенко А. Е. | ИСТНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #10                                                             *");
Console.WriteLine("* Выполнил: Власенко Артём Евгеньевич | ИСТНб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дана строка из одноразрядных цифр \"695847142536\".                     *");
Console.WriteLine("* Преобразуйте ее в матрицу 3 на 4 и подсчитайте сумму нечетных чисел.    *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int index = 0;

Console.WriteLine("\nМассив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{str[index]} \t");
        index++;
    }
    Console.WriteLine();
}

Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Сумма нечетных чисел: " + ds.Calculate(rows, columns, str));

Console.ReadKey();