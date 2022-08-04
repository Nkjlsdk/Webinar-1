//  задача на вход числа и проверить является ли оно четным, делится ли оно на два без остатка
Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
if (number%2==0)
{
    Console.WriteLine(+number+" -да");
}
else
{
    Console.WriteLine(+number+" -нет");
}