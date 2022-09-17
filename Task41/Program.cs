// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел
//  больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода 
//  стоп-слова "stop"

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3



void ReadNumber(string message)
{
 Console.WriteLine(message);
   string text = Convert.ToString(Console.ReadLine());
  string stop = "stop";
   int count = 0;
   if(text != stop)
   {
 
   
   int number = Convert.ToInt32(text);
    
     if(number > 0)
     {
        count++;
 
      } 

  
    }


   if(text == stop)
   {
     
   
   
   Console.WriteLine($"Число больше ноля было введено {count} раз.");
   return;
   }  
 ReadNumber(message);  
}
  




 


ReadNumber("Введите число:");


