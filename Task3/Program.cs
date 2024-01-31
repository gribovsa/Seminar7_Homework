// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

void ShowNum(int[] arr, int i)
{                                       //выполняется ShowNum(array, 0)   ; вызывается ShowNum(arr, 1)
                                        //выполняется ShowNum(array, 1)   ; вызывается ShowNum(arr, 2)
                                        //выполняется ShowNum(array, 2)   ; вызывается ShowNum(arr, 3)
                                        //выполняется ShowNum(array, 3)   ; вызывается ShowNum(arr, 4)
                                        //выполняется ShowNum(array, 5)   ; вызывается ShowNum(arr, 6)
                                        //выполняется ShowNum(array, 6)   ; return на предыдущую итерацию
                                        //далее происходит разворот рекурсии
                                        //выполняется ShowNum(array, 5)   ; выводим на консоль arr[5] = 34
                                        //выполняется ShowNum(array, 4)   ; выводим на консоль arr[5] = 10
                                        //выполняется ShowNum(array, 3)   ; выводим на консоль arr[5] = 0
                                        //выполняется ShowNum(array, 2)   ; выводим на консоль arr[5] = 5
                                        //выполняется ShowNum(array, 1)   ; выводим на консоль arr[5] = 2
                                        //выполняется ShowNum(array, 0)   ; выводим на консоль arr[5] = 1

    if (i > arr.Length - 1)
    {
        return;
    }
    ShowNum(arr, i + 1);
    Console.Write($"{arr[i]} ");
}

int[] array = { 1, 2, 5, 0, 10, 34 };
ShowNum(array, 0);