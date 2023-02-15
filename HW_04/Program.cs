//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите положительное число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 1){
    for(int i = 2; i <= N; i += 2) {
        Console.WriteLine(i);
    };
}else if (N == 0 || N == 1){
    Console.Write("Нет четных чисел");
}else{
    Console.Write("Неверно введено число");
};

