using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CS_Sem_8
{
    internal class DZ_Cem_8
    {
        public static void FindSomeFile(string path, string extension, string text)
        {
            if (!Directory.Exists(path))
            {
                Console.WriteLine("Не найдено");
                return;
                
            }

            var dirs = Directory.EnumerateDirectories(path);
            var files = Directory.EnumerateFiles(path);
                foreach (var file in files)
                {
                    if (Path.GetExtension(file).Equals($".{extension}")) // точку добавил в ручную, т.к. Path.GetExtension(file) выдает расширение с ней
                    {
                        Console.WriteLine(file);
                        //============Поиск текста===============
                        using (StreamReader sr = new StreamReader(file))
                        {
                            while (!sr.EndOfStream)
                            {
                                string value = sr.ReadLine();
                                if (value.Contains(text))
                                {
                                    Console.WriteLine($"Файл: {file} содержит текст: {value}");
                                    break;
                                }
                            }
                        }
                        //========================================

                    }
                    
                }
                foreach (var dir in dirs)
                {
                    FindSomeFile(dir, extension, text);
                }
        }
    }
}
