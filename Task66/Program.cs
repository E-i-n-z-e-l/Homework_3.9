// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// (num1)M = 1; (num2)N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое натуральное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int sumNumber = SumNaturalNumbers1(number1, number2);

Console.WriteLine(sumNumber);

int SumNaturalNumbers1 (int num1, int num2)
{
    if (num1 < num2) return num1 + SumNaturalNumbers1(num1 + 1, num2);
    if  (num2 < num1) return num2 + SumNaturalNumbers1(num1, num2 + 1);
    if (num1 == num2) return num1;
    else return 0;
}





















