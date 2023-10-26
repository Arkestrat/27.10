//34.4
//Console.WriteLine("Введите очередное число");
//double n = Convert.ToDouble(Console.ReadLine());
//double a, y, e;
//a = 0;
//y = 0;
//e = 1;
//for (int i = 1; i <= n; i++)
//{
//   a = a + Math.Cos(i);
//    y = y + Math.Sin(i);
//    e = e * (a / y);
//}
//Console.WriteLine($"Выражение равно ={e}");
//21.25
//Console.WriteLine("введите одну из величин первого прямоугольного паралепипеда");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("введите одну из величин первого прямоугольного паралепипеда");
//double y = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("введите одну из величин первого прямоугольного паралепипеда");
//double e = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("введите одну из величин второго прямоугольного паралепипеда");
//double qa = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("введите одну из величин второго прямоугольного паралепипеда");
//double qy = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("введите одну из величин второго прямоугольного паралепипеда");
//double qe = Convert.ToDouble(Console.ReadLine());
//double q = 0;
//double y = 0;
//q += a * y * e;
//y += qa * qy * qe;
//if (q > y)
//    Console.WriteLine("первый паралепипед больше");
//else
//    Console.WriteLine("второй паралепипед больше");
//34.11
//double c , z;
//c = 1 + Math.Sin(0.1);
//for (double i = 0.2; i <= 10; i += 0.1 )
//{
//    z = 1 + Math.Sin(i);
//    y = y * a;
//}
//Console.WriteLine($"Выражение равно ={e}");
//39.22
double summa = 0;
Console.WriteLine("Введите число окончания");
int a = Convert.ToInt32(Console.ReadLine());
while (a > 0)
{
    Console.WriteLine("Введите очередное число последовательности a=");
    double e = Convert.ToDouble(Console.ReadLine());
    double y = e % 10;
    if (y / a == 1)
        summa += e;
    else
        Console.WriteLine("число не оканчивается на заданное");
    Console.WriteLine("Продолжить ввод? Y/N");
    if (Console.ReadLine() == "N")
        break;
}
Console.WriteLine($"Сумма последовательности равна = {summa}");