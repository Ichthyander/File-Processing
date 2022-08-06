using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Обязательная задача*. Программно создайте текстовый файл и запишите в него 10 случайных чисел. 
 * Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.*/

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirPath = "Files";
            string filePath = dirPath + "//" + "Random_Numbers.txt";

            //Создаём папку, если её ещё нет
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }

            #region StreamWriter
            //Через генератор случайных чисел записываем в файл 10 чисел
            Random random = new Random();

            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                for (int i = 1; i <= 10; i++)
                {
                    sw.WriteLine(random.Next(100));
                }
            }
            #endregion

            #region StreamReader
            //Считываем строки из файла и записываем сумму в отдельную переменную
            int sum = 0;

            using (StreamReader sr = new StreamReader(filePath))
            {
                while (true)
                {
                    string str = sr.ReadLine();

                    if (str == null)
                    {
                        break;
                    }

                    sum += Convert.ToInt32(str);
                }
            }

            Console.WriteLine(sum);
            Console.ReadKey();
            #endregion
        }
    }
}
