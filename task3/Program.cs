/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет*/


Console.WriteLine("Введи цифру");
int daynumber = Convert.ToInt32(Console.ReadLine());

void checkday (int daynumber) 
{
  if (daynumber == 6 || daynumber == 7) 
  {
    Console.WriteLine("да");
  }
  else if (daynumber < 1 || daynumber > 7) 
  {
    Console.WriteLine("не подходит");
  }
  else Console.WriteLine("нет");
}
checkday(daynumber);
