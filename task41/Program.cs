// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop" и производится при помощи нажатия Enter.


int count = 0;
int number =0;
string text;

while (true)
{
    Console.WriteLine("Введите число");
    text =Console.ReadLine(); // как избавиться от подчеркивания?
    
    if (text!="stop")
    {
        number = Convert.ToInt32 (text);    
          if (number > 0)
            {
                 count++;
            }
       
    }
    else                                    
    {                                       
         System.Console.WriteLine($"Количество положительных {count}");
        break;
    }  
}

