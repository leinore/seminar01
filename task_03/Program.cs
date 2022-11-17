// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница

Console.Write("Введите номер дня недели от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.Write($"{number} - это понедельник");
}
if (number == 2)
{
    Console.Write($"{number} - это вторник");
}
if (number == 3)
{
    Console.Write($"{number} - это cреда");
}
if (number == 4)
{
    Console.Write($"{number} - это четверг");
}
if (number == 5)
{
    Console.Write($"{number} - это пятница");
}
if (number == 6)
{
    Console.Write($"{number} - это суббота");
}
if (number == 7)
{
    Console.Write($"{number} - это воскресенье");
}
if(number > 7)
{
    Console.Write("Число должно быть от 1 до 7");
}
if(number < 1)
{
    Console.Write("Число должно быть от 1 до 7");
}
