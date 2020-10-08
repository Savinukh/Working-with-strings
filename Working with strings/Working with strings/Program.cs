using System;
using System.Linq;

namespace fourthApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст:\t");
            string text = Console.ReadLine();
            Console.WriteLine("1. Посчитать кол-во знаков препинания в нем:\t" + text.Count(char.IsPunctuation));
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("\n2. Разбить текст на отдельные предложения:");
            string[] lines = text.Split(new string[] { "." }, StringSplitOptions.None);
            foreach (string line in lines)
            {
                Console.WriteLine(line.Trim(' '));
                String[] t = text.Split(' ');
            }
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("\n3. Создать массив уникальных слов в тексте и вывести их на экран через запятую:");
            //string[] arr = text.Split(' ').ToArray();
            string[] arr = text.Split(' ', ',', '.').ToArray();
            var unique = arr.Distinct();
            foreach (string i in unique) Console.WriteLine(i + ",");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("\n4. Найдите самое длинное слово во всем тексте. Выведите его на экран:");
            var result = text.Split(" ".ToCharArray(),
            StringSplitOptions.RemoveEmptyEntries).OrderByDescending(x => x.Length).FirstOrDefault();
            Console.WriteLine(result);
            Console.WriteLine("-------------------------------------------------------------------");

            int d = Convert.ToInt32(result.Length);
            if (d % 2 == 0)
            {
                Console.WriteLine("\n5. Количество букв в самом длинном слове {0}. Это четное число. Вот половина слова: ", result.Length);
                int g = d / 2;
                string a = result.Substring(g);
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("\nКоличество букв в самом длинном слове {0}. Это нечетное число: ", result.Length);

                double g = Convert.ToDouble(d);
                double s = Math.Round(g / 2, 0);
                int q = Convert.ToInt32(s);
                result = result.Remove(q, 1).Insert(q, "*".ToString());
                Console.WriteLine(result);
                Console.WriteLine("-------------------------------------------------------------------");
            }
            Console.ReadKey();

        }
    }
}