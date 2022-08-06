using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Вручную подготовьте текстовый файл с фрагментом текста. Напишите программу, 
 * которая выводит статистику по файлу - количество символов, строк и слов в тексте.*/

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Files/Article.txt";
            string text = "";
            int lineCount = 0;

            text = File.ReadAllText(path, System.Text.Encoding.GetEncoding(1251));

            int wordCount = GetWordCount(text);

            //Подсчёт количества строк
            using (StreamReader sr = new StreamReader(path))
            {
                while (true)
                {
                    string str = sr.ReadLine();

                    if (str == null)
                    {
                        break;
                    }

                    lineCount++;
                }
            }

            Console.WriteLine("Количество символов в файле - {0}", text.Length);
            Console.WriteLine("Количество строк в файле - {0}", lineCount);
            Console.WriteLine("Количество слов в файле - {0}", wordCount);

            Console.ReadKey();
        }

        static int GetWordCount(string text)
        {
            string modifiedText = "";
            foreach (char symbol in text)
            {
                if ((char.IsPunctuation(symbol)) || (char.IsDigit(symbol)) || (char.IsControl(symbol)))
                {
                    modifiedText += "";
                }
                else
                {
                    modifiedText += symbol;
                }
            }

            string[] strArray = modifiedText.Split(new char[] {' '}, System.StringSplitOptions.RemoveEmptyEntries);

            return strArray.Length;
            //return modifiedText;
        }
    }
}
