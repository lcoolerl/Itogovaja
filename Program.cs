﻿// Итоговая работа
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать
// на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Начальный массив строк
string[] array = new string[] { "qwe", "asd", "Hjkl", "h7tld", "redis", "fl" };
int n=3;

for (int i=0; i < array.Length; i++)
     {
     if (array[i].Length<=n)
     {
          Console.Write($"{array[i]} ");
     }
     }