//Задача 1. Необходимо написать программу, которая выводит случайное трёхзначное число
//и удаляет вторую цифру этого числа.
// Реализовать нужно с помощью методов.
/*
int CutNumber()
{
    int num = new Random().Next(100, 1000);
    Console.WriteLine("Current random number is " + num);

    int sotni = num / 100;//Отсекаем два первх разряда - первое число
    int ed = num % 10;//Остаток от деления на десять - второе число
    int result = sotni * 10 + ed;
    return result;
}
//Результатом метода получили число с вырезанной средней цифрой.
//Метод возвращает значение.

int number = CutNumber();
Console.WriteLine("Result number is " + number);



//Второй вариант решения задачи с невозвращаемым значением
void CutNumberVoid()
{
    int num = new Random().Next(100, 1000);
    Console.WriteLine("Current random number is " + num);

    int sotni = num / 100;//Отсекаем два первх разряда - первое число
    int ed = num % 10;//Остаток от деления на десять - второе число
    int result = sotni * 10 + ed;
    Console.WriteLine("Result number is " + result);
}   


CutNumberVoid();


//Задача. Необходимо написать программу, которая выводит случайное число
//из отрезка от 10 до 99 и показывает наибольшую цифру этого числа.


int MaxNumber()
{
    int num = new Random().Next(10 , 100);
    Console.Write(num);

    int firstnum = num % 10;
    int secondnum = num / 10;

    if (firstnum > secondnum)
    return firstnum;
    else
    return secondnum;
}

int result = MaxNumber();
Console.WriteLine("   Result number is " + result);



//Задача. Необходимо написать программу, которая принимает на вход число,
//и проверяет кратно ли оно одновременно 7 и 23?


void CheckNumber()
{
    int num;
    Console.Write("Введите целое число ");
    num = Convert.ToInt32(Console.ReadLine());

    if(num % 7 == 0)
    {
        if(num % 23 == 0)

        {
            Console.Write("Число является кратным 7 и 23.");
        }
    }
    else
    {
        Console.Write("Число не является кратным 7 и 23.");
    }
}

CheckNumber();
*/


//Задача. Написать программу которая принимает на вход два числа и 
//проверяет является ли одно число квадратом другого?


void IsQuard(int num1, int num2)
{
    int quad1 = num1 * num1;
    int quad2 = num2 * num2;

    if (num1 == quad2)
        Console.Write("Yes");
    else
        if(num2 == quad1)
            Console.WriteLine("Yes");
        else
        Console.Write("No");
}