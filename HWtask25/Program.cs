// See https://aka.ms/new-console-template for more information
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int number = A;

for(int i = 1; i < B; i++)
{
    number = number * A;
}
Console.Write("A в степени B = " + number);