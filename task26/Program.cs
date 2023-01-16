// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int count = 0;

while(A>0)
{
    A/=10;
    count++;
}
Console.WriteLine(count);
