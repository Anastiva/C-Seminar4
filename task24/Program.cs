// See https://aka.ms/new-console-template for more information

int Sum(int number)
{
    int sum = 0;
    for (int i = 1; i <= number;  i++)
    {
        sum+=i;
    }
    return sum;
}

Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int sum = Sum(A);

Console.WriteLine(sum);
