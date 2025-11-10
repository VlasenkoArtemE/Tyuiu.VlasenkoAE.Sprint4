using Tyuiu.VlasenkoAE.Sprint4.Task0.V12.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнил: Власенко А. Е. | ИСТНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #12                                                             *");
Console.WriteLine("* Выполнил: Власенко Артём Евгеньевич | ИСТНб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать произведение   *");
Console.WriteLine("* четных элементов массива.  {4 ,6 ,2 ,8 ,4 ,5 ,6 ,9 ,8 ,7}               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[] numsArray = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };

Console.WriteLine("Исходный массив:");
for (int i = 0; i <= numsArray.Length - 1; i++)
{
    Console.WriteLine(numsArray[i]);
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.GetMultEvenArrEl(numsArray));

Console.ReadKey();