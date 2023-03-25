using System.Linq;
using System.Text;

namespace _02_Homework__Array_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            //Task 1
            //Random rnd = new Random();
            //int[] array = new int[10];
            //for (int i = 0; i < array.Length; i++)
            //    array[i] = rnd.Next(-10, 10);
            //foreach (var item in array)
            //    Console.Write($"{item}  ");
            //Console.WriteLine();
            //int max = array.Max();
            //int min = array.Min();
            //Console.WriteLine($"Min element = {min}\nMax element = {max}");

            //Task 2
            //Random rnd = new Random();
            //int[] array = new int[10];
            //for (int i = 0; i < array.Length; i++)
            //    array[i] = rnd.Next(-10, 10);
            //bool duplicates = false;
            //Array.Sort(array);
            //foreach (var item in array)
            //   Console.Write($"{item}  ");
            //for (int i = 1; i < array.Length; i++)
            //{
            //    if (array[i] == array[i - 1])
            //    {
            //        duplicates = true;
            //        break;
            //    }
            //}
            //Console.WriteLine();
            //if (duplicates == true)
            //    Console.WriteLine("Duplicates found");
            //else
            //    Console.WriteLine("Duplicates not found");

            //Task 3
            //Random rnd = new Random();
            //int[] array = new int[10];
            //for (int i = 0; i < array.Length; i++)
            //    array[i] = rnd.Next(-10, 10);
            //foreach (var item in array)
            //    Console.Write($"{item}  ");
            //int res = 0;
            //int count = 0;
            //Console.WriteLine();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (((i + 1) % 2 != 0) && (array[i] % 2) == 0)
            //    {
            //        res += array[i];
            //        ++count;
            //    }
            //}
            //Console.WriteLine($"Task 3. Result = {(float)res / count}");

            //Task 4
            //Random rnd = new Random();
            //int[] array1 = new int[10];
            //int[] array2 = new int[10];
            //for (int i = 0; i < array1.Length; i++)
            //    array1[i] = rnd.Next(-20, 20);
            //foreach (var item in array1)
            //    Console.Write($"{item} ");
            //Console.WriteLine();
            //array2 = array1.Where(x => (x % 2 != 0) && (x < 0)).ToArray();
            //foreach (var item in array2)
            //    Console.Write($"{item} ");
            //Console.WriteLine();

            //Task 5
            //Random rnd = new Random();
            //int[] array1 = new int[10];
            //int[] array2 = new int[10];
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    array1[i] = rnd.Next(10, 30);
            //    array2[i] = rnd.Next(10, 30);
            //}
            //int[] resultArray = array1.Zip(array2, (a, b) => a + b).ToArray();
            //Console.WriteLine("Масив 1: \t[{0}]", string.Join(", ", array1));
            //Console.WriteLine("Масив 2: \t[{0}]", string.Join(", ", array2));
            //Console.WriteLine("Результат: \t[{0}]", string.Join(", ", resultArray));


            //Task 6
            //Random rnd = new Random();
            //int n = 20;
            //int[] array = new int[n];
            //for (int i = 0; i < array.Length; i++)
            //    array[i] = rnd.Next(0, 10);
            //Console.WriteLine("Масив: [{0}]", string.Join(", ", array));
            //// Знаходимо найдовшу послідовність чисел, впорядковану за зростанням
            //int maxLength = 1;
            //int currentLength = 1;
            //int endPosition = 0;
            //for (int i = 1; i < n; i++)
            //{
            //    if (array[i] >= array[i - 1])
            //    {
            //        currentLength++;
            //        if (currentLength > maxLength)
            //        {
            //            maxLength = currentLength;
            //            endPosition = i;
            //        }
            //    }
            //    else
            //        currentLength = 1;
            //}

            //// Виводимо найдовшу послідовність чисел, впорядковану за зростанням
            //Console.Write("Найдовша послідовність чисел, впорядкована за зростанням: ");
            //for (int i = endPosition - maxLength + 1; i <= endPosition; i++)
            //    Console.Write("{0} ", array[i]);
            //Console.WriteLine();

            //// Виводимо всі послідовності чисел з найдовшою довжиною
            //Console.Write("Всі послідовності чисел з найдовшою довжиною: ");
            //for (int i = 0; i < n - maxLength + 1; i++)
            //{
            //    currentLength = 1;
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (array[j] >= array[j - 1])
            //        {
            //            currentLength++;
            //            if (currentLength == maxLength)
            //            {
            //                for (int k = i; k <= j; k++)
            //                    Console.Write("{0} ", array[k]);
            //                Console.Write("| ");
            //            }
            //        }
            //        else
            //        {
            //            currentLength = 1;
            //            break;
            //        }
            //    }
            //}
            //Console.WriteLine();

        }

    }
}