/*: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/



Console.WriteLine("Введите первую цифру: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую цифру: ");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третию цифру: ");
int numberC = int.Parse(Console.ReadLine());

int max = numberA;

if (numberA > max)
{
    max = numberA;
}
if (numberB > max)
{
    max = numberB;
}
else
{
    max = max;
}
if (numberC > max) 
{
    max = numberC;
}
else
{
    max = max;
}

Console.WriteLine( $"Максимальное число {max}");

