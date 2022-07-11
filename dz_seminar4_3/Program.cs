// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
Random rand = new Random();

for (int x = 0; x < array.Length; x++)
     {
          array[x] = rand.Next(20);
          Console.WriteLine("Значение элемента массива" + x + "=" + array[x]);
     }