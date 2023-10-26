//На входе целое число N. Надо вывести все целые числа в промежутке от -N до N

System.Console.WriteLine("Введите целое число:");
int N = Convert.ToInt32(Console.ReadLine());
//System.Console.WriteLine(N);
int start = N*(-1);
while(N >= start){
    System.Console.Write(start + " ");
    start = start+1;
}
if(N < 0){
    System.Console.WriteLine("Вы ввели отрицательное число. Программа прекратила свою работу!");
}
if(N == 0){
    System.Console.WriteLine("Вы ввели 0! Программа прекратила свою работу!");
}
else{
    System.Console.WriteLine("Вывод чисел закончен!");
}
