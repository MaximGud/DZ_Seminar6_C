// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] GetArray(int num)
{
  int[] array = new int[num];
  for (int i = 0; i < num; i++)
  {
    array[i] = new Random().Next(-999, 1000);
  }
  return array;
}

int CountPlus(int[] arr)
{
  int count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > 0)
    {
      count += 1;
    }
  }
  return count;
}

int[] array = GetArray(size);
Console.WriteLine($"Числа: [{String.Join(",", array)}]");
Console.Write($"Из введенных {size} чисел - {CountPlus(array)} положительных.");