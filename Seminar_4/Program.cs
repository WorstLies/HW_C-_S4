// Задача 1. Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в 
// натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int result = num1;

// for (int i = 1; i < num2; i++)
// {
//    result = result*num1;
// }
// Console.WriteLine(result);

// _______________________________________________________
// Задача 2. 
// Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int sum = 0;

// int Func()
// {
//     while (num>0)
//     {
//         int i = num%10;
//         sum+=i;
//         num/=10;
//     }
//     return sum;
// }
// Console.WriteLine(Func());

// ______________________________________________________

// Задача 3.
// Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] GetArray()
{
    int [] array=new int [8];
    
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите элементы массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
Console.WriteLine(String.Join(",",GetArray()));