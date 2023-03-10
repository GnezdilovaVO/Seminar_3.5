using static Library1;
using static Library_MAX;
using static Library;

int[] array = new int[12];
FillArray(array);
Console.WriteLine(printArray(array));
Console.WriteLine("Сумма отрицательных элементов массива: " + GetNegativeResult(array));
Console.WriteLine("Сумма положительных элементов массива: " + GetPositiveResult(array));


