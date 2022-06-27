/* Задача 1. 
Запросить у пользователя два числа и определить является ли первое число
квадратом второго?

int num1, num2, quad;

Console.Write("Input a first number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

quad = num2 * num2;

if(quad == num1)
{
    Console.WriteLine("First number is quard of second number");
}

else
{
    Console.WriteLine("First number is not a quard of second number");
}


 Задача 2. 
 Необходимо написать программу которая будет выдавать название
дня недели по заданному номеру.

int day;

Console.Write("Введите число недели (от 1 до 7): ");
day = Convert.ToInt32(Console.ReadLine());

if (day == 1)
{
    Console.Write("Понедельник");
}
if (day == 2)
{
    Console.Write("Вторник");
}
if (day == 3)
{
    Console.Write("Среда");
}
if (day == 4)
{
    Console.Write("Четверг");
}
if (day == 5)
{
    Console.Write("Пятница");
}
if (day == 6)
{
    Console.Write("Суббота");
}
if (day == 7)
{
    Console.Write("Воскресенье");
}
if (day > 7 || day < 1)
{
    Console.Write("Введите корректное число");
}


Задача 3. 
Пользователь вводит число, а программа вернет значение квадрата
этого числа.


int num, quad;

Console.Write("Input a number ");
num = Convert.ToInt32(Console.ReadLine());

quad = num * num;

Console.Write("Квадрат введенного числа "+ quad);


Задача 4.
Пользователь вводит число, а программа выводит все числа от равного по значению,
но с другим знаком до этого числа.
*/

int n, current;

Console.Write("Input a number: ");
n = Convert.ToInt32(Console.ReadLine());

current = n*(-1);
while(current <= n)
{
    Console.Write(current + " ");
    current++; //current = current +1
}