// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// Console.WriteLine("Введите трехзначное число: ");
// int numbers = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// count = (numbers/10)%10;
// Console.WriteLine(count);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int numbers1 = 0;
if (numbers > 99)
{
        while (numbers > 99)
    {
        numbers1 = numbers%10;
        numbers = numbers/10;
    }
    Console.WriteLine(numbers1);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// на платформу скидывать скриншоты что ваша программа работает с самим текстом кода + в комменте ссылка на гитхаб
// всем , кто умеет - обернуть решение в функцию

// Console.WriteLine("Введите число ");
// int numbers = Convert.ToInt32(Console.ReadLine());
// if (numbers == 1)
// {
//     Console.WriteLine("Нет");
// }
// else if (numbers == 2)
// {
//     Console.WriteLine("Нет");
// }
// else if (numbers == 3)
// {
//     Console.WriteLine("Нет");
// }
// else if (numbers == 4)
// {
//     Console.WriteLine("Нет");
// }
// else if (numbers == 5)
// {
//     Console.WriteLine("Нет");
// }
// else if (numbers == 6)
// {
//     Console.WriteLine("Да");
// }
// else if (numbers == 7)
// {
//     Console.WriteLine("Да");
// }
// else 
// {
//     Console.WriteLine("Введите другое число ");
// }


