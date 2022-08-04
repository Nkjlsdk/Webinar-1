// задача  ввод числа (N), на выходе показать все чётные числа от 1 до N.
Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
int evennumber = 0;
while (evennumber < number)
{
    evennumber += 2;
    Console.WriteLine(evennumber);
}
