//using System;
//using System.IO;


//namespace ConsoleAppwipro.Day5
//{
//    internal class Filehandling_demo
//    {
//        static void Main(string[] args)
//        {
            //FileInfo f1 = new FileInfo(@"e:\CAT\Admit card.pdf");
            //Console.WriteLine(f1.Name);
            //Console.WriteLine(f1.FullName);
            //Console.WriteLine(f1.Length);
            //Console.WriteLine(f1.DirectoryName);
            //Console.WriteLine(f1.CreationTime);
            //Console.WriteLine(f1.LastWriteTime);
            //Console.WriteLine(f1.Extension);

            //DriveInfo d1 = new DriveInfo("c:\\");
            //Console.WriteLine(d1.Name);
            //Console.WriteLine(d1.TotalSize);
            //Console.WriteLine(d1.TotalFreeSpace);
            //Console.WriteLine(d1.AvailableFreeSpace);

            //DirectoryInfo df = new DirectoryInfo("e:\\CAT");
            //Console.WriteLine(df.Name);
            //Console.WriteLine(df.FullName);
            //Console.WriteLine(df.CreationTime);
            //Console.WriteLine(df.LastWriteTime);
            //Console.WriteLine(df.Extension);
            //Console.WriteLine(df.Parent);


            // ===========================================================================================================================

            // Reading the file using stream reader

            //string filepath = @"e:\abstraction_demo.cs";
            //string content;

            //using(StreamReader sr = new StreamReader(filepath))
            //{
            //    content = sr.ReadToEnd();
            //    Console.WriteLine(content);
            //}

            // Read the file using File.ReadAllText

            //content = File.ReadAllText(filepath);
            //Console.WriteLine(content);

            //=======================================================================================================================

            //string filepath = @"e:\abstraction_demo.cs";
            //string content = "Hello World!";

            //using ( StreamWriter writer = new StreamWriter(filepath ) )
            //{
            //    writer.Write( content );
            //}

            //File.WriteAllText( filepath, content );

            //using ( StreamWriter  writer = new StreamWriter(filepath,true ) )
            //{
            //    writer.WriteLine( content );
            //}

            //File.Copy( filepath, content , true);

            //Console.WriteLine(content);

            //File.Delete(filepath);
//        }
//    }
//}
