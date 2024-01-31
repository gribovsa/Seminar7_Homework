// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void Numbers(int m, int n)
{
    if (n < m)
    {
        return;
    }
    Numbers(m, n-1);                 //выполняется Numbers(1, 10); вызывается Numbers(1, 9)
                                     //выполняется Numbers(1, 9);  вызывается Numbers(1, 8)
                                     //выполняется Numbers(1, 8);  вызывается Numbers(1,7)
                                     //выполняется Numbers(1, 7);  вызывается Numbers(1,6)
                                     //выполняется Numbers(1, 6);  вызывается Numbers(1,5)
                                     //выполняется Numbers(1, 5);  вызывается Numbers(1,4)
                                     //выполняется Numbers(1, 4);  вызывается Numbers(1,3)
                                     //выполняется Numbers(1, 3);  вызывается - Numbers(1,2)
                                     //выполняется Numbers(1, 2);  вызывается - Numbers(1,1)
                                     //выполняется Numbers(1, 1);  вызывается - Numbers(1,0)
                                     //выполняется Numbers(1, 0);  return
                                     //происходит разворот функции
                                     //выполняется Numbers(1, 1);  Console.Write(1)
                                     //выполняется Numbers(1, 2);  Console.Write(2)
                                     //выполняется Numbers(1, 3);  Console.Write(3)
                                     //выполняется Numbers(1, 4);  Console.Write(4)
                                     //выполняется Numbers(1, 5);  Console.Write(5)
                                     //выполняется Numbers(1, 6);  Console.Write(6)
                                     //выполняется Numbers(1, 7);  Console.Write(7)
                                     //выполняется Numbers(1, 8);  Console.Write(8)
                                     //выполняется Numbers(1, 9);  Console.Write(9)
                                     //выполняется Numbers(1, 10);  Console.Write(10)

   
    
    Console.Write(n);
}

Numbers(1, 10);