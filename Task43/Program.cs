// Задача 43: Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToDouble(Console.ReadLine());
}



double k1 = ReadNumber("Введите угловой коэффициент прямой 1:");
double k2 = ReadNumber("Введите угловой коэффициент прямой 2:");
if(k1 == k2)
{
  Console.WriteLine("Прямые параллельны или совпадают.");
  return;
}

double b1 = ReadNumber("Введите пересечение с осью y прямой 1:");
double b2 = ReadNumber("Введите пересечение с осью y прямой 2:");




double x = (b2 - b1)/(k1 - k2);

double y = k1 * x + b1;


x = Math.Round(x, 2);
y = Math.Round(y, 2);


Console.WriteLine($"Точка пересечения двух прямых равна {x} по оси X и {y} по оси Y.");






