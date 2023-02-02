// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа num1 и num2.
// num1 = 2, num2 = 3 -> A(num1,num2) = 9
// num1 = 3, num2 = 2 -> A(num1,num2) = 29

Console.WriteLine("Введите первое натуральное число для функции Аккермана: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число для функции Аккермана: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int funcAkker = AkkermanFunc(number1, number2);
Console.WriteLine(funcAkker);

int AkkermanFunc(int num1, int num2)
{
	if(num1 == 0) return num2 + 1;

	if(num1 > 0 && num2 == 0) return AkkermanFunc(num1 - 1, 1);
	
	else return AkkermanFunc(num1 - 1, AkkermanFunc(num1, num2 - 1));
}


















