/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел*/
Console.WriteLine("Введите три числа: ");
int numberfirst = Convert.ToInt32(Console.ReadLine());
int numbersecond = Convert.ToInt32(Console.ReadLine());
int numberthird = Convert.ToInt32(Console.ReadLine());
if ((numberfirst > numbersecond) & (numberfirst > numberthird))
{
    Console.WriteLine("max = "+ numberfirst); 
}
else
{
    if (numbersecond > numberthird)
    {
         Console.WriteLine("max = "+ numbersecond);
    }
    else
    {
        Console.WriteLine("max = "+ numberthird);
    }
}
    

