// See https://aka.ms/new-console-template for more information

int Mult(int A)
{
    int mult = 1;
    for (int i = 1; i <= A;  i++)
    {
        mult*=i;
    }
    return mult;
}

Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int mult = Mult(A);

Console.WriteLine(mult);
