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

            Random random = new Random();

            StreamWriter sw = new StreamWriter(filePath);
            for (int i = 1; i <= 10; i++)
            {
                sw.WriteLine(random.Next());
            }  
            sw.Flush();

            StreamReader sr = new StreamReader(filePath);



        }
    }
}
