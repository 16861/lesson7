using System;
using System.IO;
using System.Text;

namespace task_two
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task two");

            string fileName = "file1";

            using(System.IO.FileStream fs = System.IO.File.Create(fileName)) {
                foreach(var b in Encoding.ASCII.GetBytes("some random text")) {
                    fs.WriteByte(b);
                }
                
            }

            byte[] readBuffer = System.IO.File.ReadAllBytes(fileName);
            Console.Write(Encoding.ASCII.GetString(readBuffer));
            Console.WriteLine();

            System.IO.File.Delete(fileName);
        }
    }
}
