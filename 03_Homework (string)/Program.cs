using System.Diagnostics.Tracing;
using System.Text;
using System.Text.RegularExpressions;

namespace _03_Homework__string_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            //Завдання 1
            //Console.WriteLine("Enter some words");
            //string words = Console.ReadLine();
            //string[] wordsArr = words.Split(new[] { ' ', ',', '.', '?', '!', ';' }, StringSplitOptions.RemoveEmptyEntries);
            //Array.Reverse(wordsArr);
            //Console.WriteLine(string.Join(" ", wordsArr));

            //Завдання 2
            //string str = "some.text.end";
            //int firstDotIndex = str.IndexOf('.');
            //if (0 <= firstDotIndex)
            //{
            //    int secondDotIndex = str.IndexOf('.', firstDotIndex + 1);
            //    if (firstDotIndex < secondDotIndex)
            //        Console.WriteLine(str[(firstDotIndex + 1)..secondDotIndex]);
            //}

            //Завдання 3
            //Console.WriteLine("Enter your word");
            //string? palindrom = Console.ReadLine();
            ////перевіряємо рядок
            //if (string.IsNullOrWhiteSpace(palindrom))
            //{
            //    Console.WriteLine("Invalid string");
            //    return;
            //}
            //bool isTrue = true;
            //// ще одна перевірка, обрізаємо пусті символи
            //palindrom = palindrom.Trim();
            //// основна робота, рухаємось одночасно з початку і кінця масиву до середини
            //// зводимо символи до нижнього регістру і перевіряємо чи співпадають
            //for (int i = 0; i < palindrom.Length / 2; i++)
            //{
            //    if (palindrom[i].ToString().ToLower() == palindrom[^(i + 1)].ToString().ToLower())
            //        continue;
            //    isTrue = false;
            //}
            //if (isTrue)
            //    Console.WriteLine("Your word is palindrome");
            //else
            //    Console.WriteLine("This is not palindrome");

            //Завдання 4
            //string text = "Дано певний текст. Великі І Малі Літери";
            //// визначаємо кількість літер загальну, великих та маленьких
            //int symbols = text.Where(x => char.IsLetter(x)).ToArray().Length;
            //int lowerLerrers = text.Where(x => char.IsLower(x)).ToArray().Length;
            //int upperLerrers = text.Where(x => char.IsUpper(x)).ToArray().Length;
            //// Показуємо абсолютні значення та у співвідношенні 
            //Console.WriteLine($"Малих літех {lowerLerrers} з {symbols}, тобто {Math.Round(((float)lowerLerrers / symbols * 100), 2)}%");
            //Console.WriteLine($"Великих літех {upperLerrers} з {symbols}, тобто {Math.Round(((float)upperLerrers / symbols * 100), 2)}%");

            //Завдання 5
            //string text = "Якийсь текст! Для тесту, щоб перевірити завдання";
            //Console.WriteLine(text);
            //int position = 4;      // позиція слова, яке потрібно знайти
            //// розділяємо текст на слова
            //string[] words = text.Split(new char[] {' ', ',', '.', ';', ':', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);
            //if (position < 0 || words.Length <= position)
            //{
            //    Console.WriteLine("Позиція вказана не вірна");
            //    return;
            //}
            //Console.WriteLine($"Слово з позиції {position} - \"{words[position - 1]}\", перша буква \"{(words[position - 1])[0]}\"");

            //Завдання 6
            //string[] arrStr = { "arrays", "String", "OOP", "Dev", "Administration", "C++" };
            //Console.WriteLine(string.Join(", ", arrStr.Select(w => w.Length > 5 ? w.Substring(0, w.Length - 3) + "$$$" : w).ToArray()));

            //Завдання 7
            //string str = "До тендеру допущено ТзОВ Веселка, та ТОВ Світанок";
            //string[] a_str = str.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            ////string[] result = a_str.Where(word => Regex.IsMatch(word, @"[А-Я]{2}")).ToArray();
            //Console.WriteLine(string.Join(", ", a_str.Where(word => Regex.IsMatch(word, @"[А-Я]{2}")).ToArray()));

            //Завдання 8
            //string str = "  Match one   or more word   characters  up to a   word boundary. ";
            //str = string.Join("*", str.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries));
            //Console.WriteLine(str);

        }
    }
}