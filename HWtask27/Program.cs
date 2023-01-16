// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while(A > 0)
{
    int numbers = A % 10;
    A = A / 10;
    sum += numbers;
}
Console.WriteLine("Cумма всех цифр в числе = " + sum);