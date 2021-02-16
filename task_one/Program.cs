using System;
using System.IO;

namespace task_one
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("first task");

            string folder_name = "folder";

            for(int i = 0; i <= 10; i++) {
                DirectoryInfo dirInfo = new DirectoryInfo(folder_name + i.ToString());
                
                var x = Directory.CreateDirectory(dirInfo.FullName);
                
                Console.WriteLine($"Is directiry exists: {System.IO.Directory.Exists(folder_name + i.ToString())}");

                dirInfo.Delete();
            }
        }
    }
}
