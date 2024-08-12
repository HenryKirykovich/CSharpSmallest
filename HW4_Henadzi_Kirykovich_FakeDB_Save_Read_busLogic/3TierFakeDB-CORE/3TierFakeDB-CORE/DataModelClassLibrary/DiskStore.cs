using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataModelClassLibrary
{
    public static class DiskStore
    {
        static string currenctDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\arrayDara.txt";


        public static void WriteStringArray(string[,] fakeDB)
        {
            StreamWriter fileWriter = new StreamWriter(currenctDocPath);
            for (int i = 0; i < fakeDB.GetLength(0); i++)
            {
                for (int j = 0; j < fakeDB.GetLength(1); j++)
                {
                    fileWriter.WriteLine(fakeDB[i, j]);
                }
            }
            fileWriter.Close();
        }

        public static string[,] ReadStringArray()
        {
            VerifyFileExist(10, 3);
            string[,] readArray = new string[10, 3];

            StreamReader fileReade = new StreamReader(currenctDocPath);

            for (int i = 0; i < readArray.GetLength(0); i++)
            {
                for (int j = 0; j < readArray.GetLength(1); j++)
                {
                    readArray[i, j] = fileReade.ReadLine();
                }
            }
            fileReade.Close();

            return readArray;
        }

        public static bool VerifyFileExist(int rows, int columns)
        {
            try
            {
                if (File.Exists(currenctDocPath))
                {
                    return true;
                }
                else
                {
                    CreateFile(rows, columns); // this method will create the file

                    return true;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("We have a problem: " + ex.Message);
            }
            return false; // have to keep the compiler happy

        }

        private static void CreateFile(int rows, int columns)
        {
            StreamWriter arrayCreator = new StreamWriter(currenctDocPath);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arrayCreator.WriteLine("");
                }
            }
            arrayCreator.Close();




        }

    }
}
