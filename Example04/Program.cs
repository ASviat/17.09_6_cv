Console.WriteLine("Введите целое число, плиз");
int num=Convert.ToInt32(Console.ReadLine());
int count=-num;
while (count<=num)
{
    Console.Write($"{count} ");
    count++;
}
