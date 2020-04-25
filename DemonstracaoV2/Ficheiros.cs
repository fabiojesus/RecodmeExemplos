using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace DemonstracaoV2
{

    



    public class Ficheiros
    {
        #region Files 
        public static void FileFunctions()
        {

            string folderPath = @"C:/demo";
            string fileName = @"test2.txt";
            FileStream stream;
            #region Create File 

            stream = File.Create(folderPath + @"/" + fileName);
            stream.Close();
            #endregion

            #region Open File 

            stream = File.Open(folderPath + @"/"+fileName, FileMode.Open, FileAccess.Read);
            stream.Close();
            #endregion



            #region Write File
            File.WriteAllText(folderPath + @"/" + fileName, "There's a snake in my boot!");
            #endregion

            #region Read File
            Console.WriteLine(File.ReadAllText(folderPath + @"/" + fileName));
            #endregion

            #region File Exists
            Console.WriteLine(File.Exists(folderPath + @"\" + fileName));
            #endregion

            #region Delete File
            File.Delete(folderPath + @"\" + fileName);
            #endregion

            #region File Exists
            Console.WriteLine(File.Exists(folderPath + @"\" + fileName));
            #endregion
        }
        #endregion

        #region Stream Writter e Reader
        
        public static void TestOutStreamWritterAndReader()
        {
            string folderPath = @"C:/demo";
            string fileName = @"test2.txt";
            using (var sw = File.CreateText(folderPath + "/" + fileName))
            {
                sw.WriteLine("The FitnessGram™ Pacer Test .");
            }

            using (var sr = new StreamReader(folderPath + "/" + fileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }


        #endregion

        #region Directories 
        
        public static void TestingDirectoryClass()
        {
            string folderPath = @"C:/demo";

            #region Create Folder
            Directory.CreateDirectory(folderPath + "/" + "test");
            #endregion
            
            #region Folder Exists
            Console.WriteLine(Directory.Exists(folderPath + "/" + "test"));

            #endregion

            #region Delete Folder
            Directory.Delete(folderPath + "/" + "test");

            #endregion

            #region Folder Exists
            Console.WriteLine(Directory.Exists(folderPath + "/" + "test"));
            #endregion
        }


        #endregion

        #region Path

        public static void TestPathClass()
        {


            string folderPath = @"C:\demo";
            string fileName = @"test2.txt";

            #region Join path
            string path = Path.Combine(folderPath, fileName);
            Console.WriteLine(path);
            #endregion

            #region Get Extension
            Console.WriteLine(Path.GetExtension(path));
            #endregion

            #region Get Root
            Console.WriteLine(Path.GetPathRoot(path));
            #endregion

        }


#endregion  

    }
}
