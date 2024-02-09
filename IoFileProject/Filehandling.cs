using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoFileProject
{
    public class Filehandling
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\Ramisettylokesh\OneDrive\Desktop\IOfile.txt";

            //Creating a path
            using (StreamWriter sw = new StreamWriter(filepath))
            {
                // writing a content in a file
                sw.WriteLine("Hello, this is written to the file!");
                sw.WriteLine("This is Lokesh");
                sw.WriteLine("From Bangalore");


            }
            System.Console.WriteLine("File created and written to: " + filepath);

           // Reading a content from file

            using (StreamReader sr = new StreamReader(filepath))
            {
                string content = sr.ReadToEnd();
                Console.WriteLine("Content in the file\n " + content);
            }

            //Checking a file exists or not

            if (File.Exists(filepath))
            {
                Console.WriteLine("File exists at path " + filepath);
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }

            //Deleting a File if it is Exist

            //if (File.Exists(filepath))
            //{
            //    File.Delete(filepath);
            //    Console.WriteLine("File is Deleted at path " + filepath);
            //}
            //else
            //{
            //    Console.WriteLine("File doesn't exist at path " + filepath);
            //}

            //------2nd code
            // Create a program that copies the contents of one text file to another.Prompt the user to enter the paths of the source and destination files.

            //string filepath = @"C:\Users\Ramisettylokesh\OneDrive\Desktop\ReviewFile.txt";

            //string filepath2 = @"C:\Users\Ramisettylokesh\OneDrive\Desktop\transferfile.txt";

            //using (StreamWriter sw = new StreamWriter(filepath))
            //{
            //    sw.WriteLine("this is lokesh R");
            //    sw.WriteLine("learning DotNet full stack with Angular");
            //    sw.WriteLine("from Bangalore");
            //    sw.WriteLine("hello world");
            //}
            //System.Console.WriteLine("File is created and written: " + filepath);

            //using (StreamReader sr = new StreamReader(filepath))
            //{
            //    string content = sr.ReadToEnd();

            //    Console.WriteLine("File is readed: " + content);
            //    using (StreamWriter sw1 = new StreamWriter(filepath2))
            //    {
            //        sw1.WriteLine(content);
            //    }
            //}


        }
    }
}
