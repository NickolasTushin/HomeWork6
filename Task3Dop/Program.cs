// Задача: Площадь треугольника

// По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) требуется вычислить его площадь.
// Входные данные:
// Входной файл INPUT.TXT содержит 6 целых чисел x1,y1,x2,y2,x3,y3 – координаты вершин треугольника.
// Все числа не превышают 106 по абсолютной величине.
// Выходные данные:
// В выходной файл OUTPUT.TXT выведите точное значение площади заданного треугольника.

Console.Clear();
Console.Write("Введите через пробел координаты вершин (x1, y1, x2, y2, x3, y3): ");


double[] array = Console.ReadLine().Split(" ").Select(x => double.Parse(x)).ToArray();

double a = Math.Sqrt(Math.Pow(array[0] - array[2], 2) + Math.Pow(array[1] - array[3], 2));
double b = Math.Sqrt(Math.Pow(array[2] - array[4], 2) + Math.Pow(array[3] - array[5], 2));
double c = Math.Sqrt(Math.Pow(array[0] - array[4], 2) + Math.Pow(array[1] - array[5], 2));;
double p = (a + b + c) / 2;
double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));


Console.WriteLine($"Площадь треугольника  =  {Math.Round(s, 2)}");