// See https://aka.ms/new-console-template for more information
int [] array = new int[8];
Console.Write("[ ");

for (int i = 0; i < array.Length; i++)
 {
    array [i] = new Random().Next(0, 11);
    Console.Write(" " + Method (i) + " ,");
 }
Console.Write(" ]"); 

int Method (int a)
{
    return array[a];
}


