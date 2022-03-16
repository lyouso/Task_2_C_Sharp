Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b) Console.WriteLine("Вы ввели равные числа");
else {
    if (a > b) Console.WriteLine("Число " + a + " больше числа " + b);
    else Console.WriteLine("Число " + b + " больше числа " + a); 
}