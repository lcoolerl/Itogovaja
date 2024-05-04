// Итоговая работа
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать
// на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Начальный массив строк
string[] array = new string[] { "qwe", "asd", "Hjkl", "h7tld", "redis", "fl" };
string[] newarray = new string[array.Length];
int n=3;
int l=0;
//Создание нового массива
for (int i=0; i < array.Length; i++)
     {
     if (array[i].Length<=n)
     {
          newarray[l]=array[i];
          l++;
     }
     }
// newarray=newarray.Trim();
System.Console.WriteLine(newarray.Length);
//Вывод полученного массива на экран
for (int j=0; j < newarray.Length; j++)
     {
          Console.Write($"{newarray[j]} ");
     }