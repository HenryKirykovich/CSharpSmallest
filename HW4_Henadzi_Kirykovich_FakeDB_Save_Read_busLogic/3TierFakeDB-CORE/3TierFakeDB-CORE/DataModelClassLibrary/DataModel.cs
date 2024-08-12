using System;

namespace DataModelClassLibrary
{
    public class DataModel
    {
        private static string[,] fakeDB = new string[10, 3];

        public static bool SaveNewPermit(string userName, string zip)
        {

            fakeDB = DiskStore.ReadStringArray();
            for (int i = 0; i < fakeDB.GetLength(0); i++)
            {
                if (fakeDB[i, 0] == null || fakeDB[i, 0] == "")
                {
                    fakeDB[i, 0] = userName;
                    fakeDB[i, 1] = zip;
                    fakeDB[i, 2] = DateTime.Now.ToShortDateString();
                    DiskStore.WriteStringArray(fakeDB);
                    return true; // success
                }
                
            }
            return false; //  return false if full
        }

        public static string[,] GetPermitsDM()
        {
            
            return DiskStore.ReadStringArray();
        }
    }
}
