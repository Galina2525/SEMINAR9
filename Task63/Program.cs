// Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от 1 до N
// Console.WriteLine("Enter N");
// int N = Convert.ToInt32(Console.ReadLine());

// for(int i = 1; i <= N; i++)
// {
    
//     Console.Write(i);
// }

String Queue(int i, int n)
{
    if (i > n) return " ";
    else return $"{i}," + Queue(i + 1, n);
}
Console.WriteLine(Queue(4,8));
