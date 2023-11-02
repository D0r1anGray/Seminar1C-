// Напишите программу, которая принимает на вход трёхзначное целое число и на выходе показывает сумму первой и последней цифры
using System.ComponentModel.DataAnnotations;

System.Console.WriteLine("Ввведите трёхзначное целое число:");
int number = Convert.ToInt32(Console.ReadLine());
if(number.ToString().Length <3 || number.ToString().Length > 3){
    System.Console.WriteLine("Вы ввели не трёхзначное число!!!");
}
else{
    System.Console.WriteLine("Результат сложения первой и последней цифры числа: " + (number/100+number%10));
}