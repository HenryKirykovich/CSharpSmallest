using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteStringArray
{
class Program
{
    static string currentDocPath = 
        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
        "\\arrayData.txt";

    static void Main(string[] args)
    {
        string[,] nameArray = new string[2,2];  // holds are data entered from keyboard
        string[,] readArray = new string[2,2];  // our disk read code will put its data in here

        Console.Write("enter first first name:  ");
        nameArray[0, 0] = Console.ReadLine();
        Console.Write("enter first last name:  ");
        nameArray[0, 1] = Console.ReadLine();
        Console.Write("enter second first name:  ");
        nameArray[1, 0] = Console.ReadLine();
        Console.Write("enter second last name:  ");
        nameArray[1, 1] = Console.ReadLine();

            // ========================================================
            // ========================================================
            // VerifyFileExist(2, 2); no need to do this as StreamWriter will create it if it does not exist.


            // call the constructor
            StreamWriter fileWriter = new StreamWriter(currentDocPath);
        // write four lines to the file stream
        for (int i = 0; i < 2; i++)  // loops should not be hardcoded to 2's!
        {
            for (int j = 0; j < 2; j++)
            {
                    fileWriter.WriteLine(nameArray[i, j]);
            }
        }
        fileWriter.Close();  // make sure to always close!

        // ========================================================
        // This first code will make sure this is such a file
        // and if there is not, it writes 4 lines of blank lines
        // so that our read will not fail

        VerifyFileExist(2, 2);  // if there is no such file, create it
           
        StreamReader fileReader = new StreamReader(currentDocPath);

        // now read 4 lines and store each into array
        for (int i = 0; i < 2; i++)   // loops should not be hardcoded to 2's
        {
            for (int j = 0; j < 2; j++)
            {
                readArray[i, j] = fileReader.ReadLine(); 
            }
            }
            
        fileReader.Close();  // make sure to always close

        // ========================================================
        // write the data out to console to verify
        for (int i = 0; i < readArray.GetLength(0); i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine(readArray[i, j]);
            }
        }
        Console.ReadLine();
            
    }

    public static bool VerifyFileExist(int rows, int columns)
    {
        try
        {
            if (File.Exists(currentDocPath))
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
        StreamWriter arrayCreator = new StreamWriter(currentDocPath);
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
