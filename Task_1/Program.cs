using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Обязательная задача*. Выберите любую папку на своем компьютере, имеющую вложенные директории. 
 * Выведите на консоль ее содержимое и содержимое всех подкаталогов.*/

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Temp";

            if (Directory.Exists(path))
            {
                Console.WriteLine(@"Список директорий в папке C:\Temp");
                Console.WriteLine();

                string[] directories = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);

                foreach (string directory in directories)
                {
                    Console.WriteLine(directory);
                }

                Console.WriteLine();
                Console.WriteLine(@"Список файлов в папке C:\Temp");

                string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Указанная папка отсутствует на диске");

                Console.ReadKey();
            }
        }
    }
}
