using System;
int[] array1 = new int[] { 1, 2, 3, 4, 5 };
int[] array2 = new int[] { 6, 7, 8, 9, 10 };
int[] mergedArray = new int[array1.Length + array2.Length];
Array.Copy(array1, 0, mergedArray, 0, array1.Length);
Array.Copy(array2, 0, mergedArray, array1.Length, array2.Length);
foreach (int num in mergedArray)
{
    Console.Write(num + " ");
}
    