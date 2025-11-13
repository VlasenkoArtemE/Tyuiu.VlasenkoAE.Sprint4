using Tyuiu.VlasenkoAE.Sprint4.Task6.V18.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнил: Власенко А. Е. | ИСТНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Класс Array                                                       *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #18                                                             *");
Console.WriteLine("* Выполнил: Власенко Артём Евгеньевич | ИСТНб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан строковый массив данных [\"Собака\", \"Кошка\", \"Кролик\",         *");
Console.WriteLine("* \"Хомяк\", \"Попугай\", \"Рыбка\", \"Черепаха\"], используя класс       *");
Console.WriteLine("* Array, выведите элементы массива, длина которых больше 6 символов.      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

var mas = new string[] { "Собака", "Кошка", "Кролик", "Хомяк", "Попугай", "Рыбка", "Черепаха" };

Console.WriteLine("Исходный массив: ");
for (int i = 0; i < mas.Length; i++)
{
    Console.WriteLine(mas[i]);
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Элементы массива, длина которых больше 6 символов: ");

string[] res = ds.Calculate(mas);

for (int i = 0; i < res.Length; i++)
{
    Console.WriteLine(res[i]);
}

Console.ReadKey();