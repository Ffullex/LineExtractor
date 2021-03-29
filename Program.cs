using System;
using System.IO;

namespace LineExtractor_HCI
{
    class Program
    {
        static void Main(string[] args)
        {
            String line;
            Console.WriteLine("Введите путь до файла");
            string path = Console.ReadLine();
            Console.WriteLine(path);
            try
            {
                //Передайте путь к файлу и имя файла конструктору StreamReader.
                StreamReader sr = new StreamReader(path);
                //Прочтите первую строку текста
                line = sr.ReadLine();
                //Продолжайте читать, пока не дойдете до конца файла
                while (line != null)
                {
                    //напишите ложь в окно консоли
                    Console.WriteLine(line);
                    //Прочтите следующую строку
                    line = sr.ReadLine();
                }
                //закройте файл
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
