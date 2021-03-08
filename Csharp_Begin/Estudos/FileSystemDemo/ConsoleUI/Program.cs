using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"D:\FileSystemTest";

            //string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);

            //foreach (string dir in dirs)
            //{
            //    Console.WriteLine(dir);
            //}

            //var files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);

            //foreach (string file in files)
            //{
            //    // Console.WriteLine(file);
            //    // Console.WriteLine(Path.GetFileName(file));
            //    // Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            //    // Console.WriteLine(Path.GetDirectoryName(file));
            //    var info = new FileInfo(file);

            //    Console.WriteLine($"{Path.GetFileName(file)}: {info.Length} bytes");
            //}

            // string NewPath = @"D:\FileSystemTest\SubFolderC\SubSubFolderD\SubSubSubFolderA";
            // Directory.CreateDirectory(NewPath);

            //bool DirectoryExists = Directory.Exists(NewPath);

            //if (DirectoryExists)
            //{
            //    Console.WriteLine("The Directory exists");
            //}

            //else
            //{
            //    Console.WriteLine("The Directory does not exist");
            //    Directory.CreateDirectory(NewPath);
            //}

            //string[] files = Directory.GetFiles(rootPath);
            //string destinationFolder = @"D:\FileSystemTest\SubFolderA\";

            //foreach (string file in files)
            //{
            //    File.Copy(file, $"{destinationFolder}{Path.GetFileName(file)}", true);
            //}

            //for (int i = 0; i < files.Length; i++)
            //{
            //    File.Copy(files[i], $"{destinationFolder}{i}.txt", false);
            //}

            //foreach (string file in files)
            //{
            //    File.Move(file, $"{destinationFolder}{Path.GetFileName(file)}");
            //}


            var files = Directory.GetFiles(rootPath, "*folder*.*", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                Console.WriteLine(file);
                //    // Console.WriteLine(Path.GetFileName(file));
                //    // Console.WriteLine(Path.GetFileNameWithoutExtension(file));
                //    // Console.WriteLine(Path.GetDirectoryName(file));
                //    var info = new FileInfo(file);

                //    Console.WriteLine($"{Path.GetFileName(file)}: {info.Length} bytes");
            }


            Console.ReadLine();
        }
    }
}
