// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел
//  больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода 
//  стоп-слова "stop"

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// Долго думал, но так и не реализовал т.н. защиту от дурака, при вводе недопустимого значения, то есть не числа или слова stop, программа просто вылетает.

void ReadNumber(string message)
{
 
 int count = 0;
 
 while (true) 
 {
  Console.WriteLine(message);
  string text = Console.ReadLine();
  string stop = "stop";

  if(text == stop)
  {
    Console.WriteLine($"Число больше ноля было введено {count} раз(а).");
  return;
  }
   int number = Convert.ToInt32(text);
   if(number > 0)
  {
    count++;

  }
   
}  

}
  




 


ReadNumber("Введите число:");


