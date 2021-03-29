using System;
using System.IO;


namespace LineExtractor_HCI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                String line; //строка с блокнота
                Console.WriteLine("Введите путь до файла (Пример: С:\\Sample.txt)");
                string path = Console.ReadLine();
                Console.WriteLine("Введите номера строк, которые необходимо достать");
                string linesNum = Console.ReadLine();
                //Console.WriteLine(path);
                //Передайте путь к файлу и имя файла конструктору StreamReader.
                var reader = new StreamReader(path);
                //Прочтите первую строку текста
                line = reader.ReadLine();
                //Продолжайте читать, пока не дойдете до конца файла
                while (line != null)
                {
                    //напишите ложь в окно консоли
                    Console.WriteLine(line);
                    //Прочтите следующую строку
                    line = reader.ReadLine();
                }
                //закройте файл
                reader.Close();
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
