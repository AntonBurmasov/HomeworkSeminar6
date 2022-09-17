// Задача 40: Напишите программу, которая принимает на вход три числа
//  и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника 
// меньше суммы двух других сторон.


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


void MethodForCheckingSides(int numA, int numB, int numC)
{
 if(numA < numB + numC)
  { 
    if(numB < numA + numC)
    {
      if(numC < numA + numB)
      {
        Console.WriteLine($"Треугольник со сторонами {numA} {numB} и {numC} может существовать.");

      }
       else
      {
        Console.WriteLine($"Треугольник со сторонами {numA} {numB} и {numC} существовать не может.");

      }        
    }
    
     else
     {
    Console.WriteLine($"Треугольник со сторонами {numA} {numB} и {numC} существовать не может.");

     }

  }
  else
  {
    Console.WriteLine($"Треугольник со сторонами {numA} {numB} и {numC} существовать не может.");

  }

}





int numA = ReadNumber("Введите число 1:");

int numB = ReadNumber("Введите число 2:");

int numC = ReadNumber("Введите число 3:");

MethodForCheckingSides(numA, numB, numC);










