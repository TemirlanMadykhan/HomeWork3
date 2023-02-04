//Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int index = 1;

while (index <= N)
{
    int result = (int) Convert.ToInt32(Math.Pow(index, 3));
    Console.WriteLine(result);
    index++;
}