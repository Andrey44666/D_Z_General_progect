// Составил блок-схему проверки суммы двух чисел чисел A и B по отношению к 0.
// Последовательность, алгоритм решения:
// Пользователь вводит натуральные числа А и В.
// Создается переменная под названием S и присваиваивается сумма чисел A и B.
// Задается условие (S > 0?), при выполнение условия - (Вывод > 0),если условие не выполняется, то задется второе условие (S < 0?), если условие выполняется, то (сумма < 0), иначе (сумма = 0).
// Конец.

System.Console.WriteLine("Enter number A: ");
int numberA = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter number B: ");
int numberB = Convert.ToInt32(System.Console.ReadLine());

int S = numberA + numberB;
if (S > 0)
{
System.Console.WriteLine("conclusion > 0");
}
else if (S < 0)
{
System.Console.WriteLine("the amount < 0");
}
else
{
System.Console.WriteLine("the amount = 0");
}