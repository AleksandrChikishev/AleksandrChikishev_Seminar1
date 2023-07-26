/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3


Console.WriteLine("Введите первое число: ");
int intNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int intNumber2 = Convert.ToInt32(Console.ReadLine());

if (intNumber1 > intNumber2)
    Console.WriteLine($"Первое число {intNumber1}; больше чем второе число {intNumber2}; intNumber1 = {intNumber1}; intNumber2 = {intNumber2} -> max {intNumber1} ");
else
    Console.WriteLine($"Второе число {intNumber2}; больше чем первое число {intNumber1}; intNumber1 = {intNumber1}; intNumber2 = {intNumber2} -> max {intNumber2} ");
*/

/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int intNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int intNumber2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int intNumber3 = Convert.ToInt32(Console.ReadLine());

if ((intNumber1 > intNumber2) & (intNumber1  > intNumber3))
    Console.WriteLine($"Первое число {intNumber1} больше чем второе число {intNumber2} и третье {intNumber3}; {intNumber1}, {intNumber2}, {intNumber3} -> {intNumber1} ");
else if (intNumber2 > intNumber3)
    Console.WriteLine($"Второе число {intNumber2} больше чем первое число {intNumber1} и третье {intNumber3}; {intNumber1}, {intNumber2}, {intNumber3} -> {intNumber2} ");
else 
    Console.WriteLine($"Третье число {intNumber3} больше чем первое число {intNumber1} и второе {intNumber2}; {intNumber1}, {intNumber2}, {intNumber3} -> {intNumber3} ");
*/

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет


Console.WriteLine("Введите число: ");
int intNumber1 = Convert.ToInt32(Console.ReadLine());

if (intNumber1 % 2 == 0)
    Console.WriteLine($"Число {intNumber1} является чётным и делится на два без остатка; {intNumber1} -> да ");
else
    Console.WriteLine($"Число {intNumber1} не является чётным и не делится на два без остатка; {intNumber1} -> нет ");
*/

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.WriteLine("Введите любое число: ");
int intNumber1 = Convert.ToInt32(Console.ReadLine());
string s = "";

while (intNumber1 <= 1)
{
    Console.Write("Вы ошиблись! Введите любое число начиная с 2ух: ");
    intNumber1 = Convert.ToInt32(Console.ReadLine());
}

for (int i = 1; i <= intNumber1; i++)
{
    if (i % 2 == 0) 
        s = s + ($"{i } ");
}

Console.WriteLine($"{intNumber1} -> {s} ");
*/

