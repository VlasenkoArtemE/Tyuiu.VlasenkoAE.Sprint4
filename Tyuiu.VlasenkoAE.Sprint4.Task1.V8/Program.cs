using System.ComponentModel.DataAnnotations;
using Tyuiu.VlasenkoAE.Sprint4.Task1.V8.Lib;

DataService ds  = new DataService();

Console.Title = "Спринт #4 | Выполнил: Власенко А. Е. | ИСТНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнил: Власенко Артём Евгеньевич | ИСТНб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов заполненный         *");
Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 9 подсчитать сумму          *");
Console.WriteLine("* нечетных элементов массива.                                             *");
Console.WriteLine("* С клавиатуры: 8, 4, 7, 7, 3, 8, 8, 5, 8, 7, 2, 4.                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int len;
Console.WriteLine("Введите количество элементов масива: ");
len = Convert.ToInt32(Console.ReadLine());

int[] numsArray = new int[len];

for (int i = 0; i <= len - 1; i++)
{
    Console.WriteLine("Введите значение " + i + " элемента массива: ");
    numsArray[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine("Массив: ");
for (int i = 0; i <= len - 1; i++)
{
    Console.WriteLine(numsArray[i] + "\t");
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.Calculate(numsArray));

Console.ReadKey();