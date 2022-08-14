/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/
int[] array = new int[8];

char comma = ',';                                //для функции
System.Console.Write("[");

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    noComma(i);

    System.Console.Write(" " + array[i] + comma);

}
System.Console.WriteLine(" ]");

int noComma(int a)                              //функция для замены запятой на пробел(Первый раз делал через if) Функция ради функции
{
    if (a == (array.Length - 1))
    {
        comma = ' ';
    }
    return comma;

}