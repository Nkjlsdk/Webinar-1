/* задача на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.*/
Console.Write("Введите число №1: ");
int numberfirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число №2: ");
int numbersecond = Convert.ToInt32(Console.ReadLine());
if (numberfirst > numbersecond)
{
    Console.WriteLine(numberfirst + "-большее, " + numbersecond +"-меньшее");
}
else if (numberfirst < numbersecond)
{
Console.WriteLine(numberfirst + "-меньшее, " + numbersecond + "-большее");
}
else
{
    Console.WriteLine(numberfirst + " равно " + numbersecond);
}