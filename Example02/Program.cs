Console.WriteLine("Выполняю пш-пш программу проверки, является ли первое число квадратом второго");
Console.Write("Введите первое целое число: ");
int num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Оу даа");
Console.WriteLine("Введите второе целое число: ");
int num2=Convert.ToInt32(Console.ReadLine());
if(num1==num2*num2)
{
    Console.WriteLine ("Таки магия свершилась, таки является квадратом второго ");
}
else
{
    Console.WriteLine("Неа");
}