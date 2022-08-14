/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

System.Console.WriteLine("Введите первое число");
int numA = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите второе число");
int numB = int.Parse(Console.ReadLine());
int result = numA;

for (int i = 1; i < numB; i++)
{
    result = result * numA;
}
System.Console.WriteLine(numA + " в степени " + numB + " = " + result);