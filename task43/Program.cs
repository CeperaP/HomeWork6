// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Enternumb(string message)
{
    System.Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}
double b1 = Enternumb($"Введите точку пересечения прямых с осью Y b1:\t");
double k1 = Enternumb($"Введите угловой коэффициент k1:\t");
double b2 = Enternumb($"Введите точку пересечения прямых с осью Y b2:\t");
double k2 = Enternumb($"Введите угловой коэффициент k2:\t");

  (double x ,double y,double b1, double k1, double b2 ,double k2) Foo()
{
      double x=0;double y=0;
    x =(b2-b1)/(k1-k2);
    y=k1*x+b1;
    return (x,y,b1,k1,b2,k2);    
}

 (double xx ,double yy,double b11, double k11, double b22,double k22)= Foo();
 if (k1==k2)
 {
    System.Console.WriteLine("Линии не пересекаются");
 }
 else
 {
    System.Console.WriteLine($"Координата x={xx},координата y={yy}");
 }