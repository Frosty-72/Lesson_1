
/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/



Console.WriteLine("Сравним два числа ");
            int a, b;
            Console.WriteLine("Напишите первое число ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Напишите первое число ");
            b = Convert.ToInt32(Console.ReadLine());
 
            bool num0 = a > b;
            bool num1 = a == b;
            bool num2 = a < b;
 
            if (num0)
            {
                Console.WriteLine($"Число {a} больше чем {b}");
            }
            else if (num1)
            {
                Console.WriteLine($"Числа {a} и {b} равны");
            }
            else
            {
                Console.WriteLine($"Число {b} больше чем {a}");
            }