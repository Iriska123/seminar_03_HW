/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
(первое == последнему, второе == предпоследнему).
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите 5-ти значное число: ");  //10 000 - 99 999    53635
int num = int.Parse(Console.ReadLine());
if (num/10000 < 1 || num/10000 > 9) {
  Console.WriteLine("Число не пятизначное!");
  return;
};

int x1 = num/10000;
Console.WriteLine("x1 = " + x1);
int x2 = (num/1000)%10;
Console.WriteLine("x2 = " + x2);


int a = num%100;
Console.WriteLine("a = " + a);

int y1 = a%10;
Console.WriteLine("y1 = " + y1);
int y2 = a/10;
Console.WriteLine("y2 = " + y2);

if (x1 == y1 && x2 == y2) {
Console.WriteLine(num + " палиндром");
} else {
  Console.WriteLine(num + " НЕ палиндром");
}