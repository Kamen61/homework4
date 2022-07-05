// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// System.Console.Write("Введите первое число : ");
// int a=Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второе число : ");
// int b=Convert.ToInt32(Console.ReadLine());

// int result=1;

// for (int i=0;i<b;i++){
//     result=result*a;
// }
// System.Console.WriteLine(result);




// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// System.Console.Write("Введите число : ");
// int number=Convert.ToInt32(Console.ReadLine());
// int result=0;
// while(number!=0){
//     result=result+number%10;
//     number=number/10;
// }
// System.Console.WriteLine(result);





// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] array=new int[8];
for (int i=0;i<array.Length;i++){
    array[i]=new Random().Next(100);
}
System.Console.WriteLine($"[{string.Join("; ", array)}]");