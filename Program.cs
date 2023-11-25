using System.Diagnostics;

namespace CS_Sem_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CopyFileMetods.MyCopyFile(@"C:\Users\Valentin\Desktop\C#\CS_Sem_8\CS_Sem_8\Program.cs", "test.txt");
            //CopyFileMetods.CopyFile(@"C:\Users\Valentin\Desktop\C#\CS_Sem_8\CS_Sem_8\Program.cs", "test2.txt"); // запишет в рабочую директорию(где exe)

            //FindFileMetod.FindSomething("D:\\Разное\\Pony", "Pony");

            //SomeReadMetod.ReadSomething(@"D:\Разное\Pony\Пони.txt");

            //ChangeFilsMetod.ChangeSomeFile(@"D:\Разное\Pony\Pony_test.txt");

            DZ_Cem_8.FindSomeFile(@"D:\Разное\Test\", "txt", "Test");
        }



    }
}
