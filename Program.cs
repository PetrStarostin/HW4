// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// int Pownum(int num , int grade)
// {
//     for(int i = 1; i < grade ; i++)
//     {
//         num *= num;
//     }
//     return num ; 
// }
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите степень: ");
// int grade = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{num} в степени {grade} : {Pownum(num, grade)}");

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// int SumofNumbers(int num)
// {
//     int result = 0;
//     while(num > 0)
//     {
//         result += num % 10; 
//         num = num / 10 ;
//     }
//     return result;
// }
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма числа {num}: {SumofNumbers(num)}");

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// int [] CreateRandomArray()
// {
//     int[] array = new int[8];

//     for(int i = 0;  i < 8; i++)
//         array[i] = new Random().Next(1, 10 + 1);
    
//     return array;
// }

// void WriteArray(int[] array)
// {
//     for(int i = 0 ; i < array.Length; i++)
//         Console.Write(array[i] + " ");
    
//     Console.WriteLine();
// }

// WriteArray(CreateRandomArray());