using DataModelClassLibrary;
using System;

namespace _3TierFakeDB_CORE
{
    public class BusLogic
    {
        public static void ValidateAndRecord(string[] pElementsToCheck)
        {
            string userName = pElementsToCheck[0];
            string ZIP = pElementsToCheck[1];
            if (userName.Length < 4 || userName.Length > 20)
            {
                throw new ApplicationException("Name must be more than 3 and less than 21 characters");
            }
            if (ZIP.Length < 5 || ZIP.Length > 5)
            {
                throw new ApplicationException("ZIP must be exactly 5 characters");
            }

            bool success = DataModel.SaveNewPermit(userName, ZIP);
            if (!success)
            {
                throw new ApplicationException("Database is full.");
            }
        }  // end of validate method

        public static string[,] GetPermits(string pPW)
        {
            if (pPW == "77")
            {
                string[,] tempArray = DataModel.GetPermitsDM();
                return tempArray;
            }
            else
            {
                throw new ApplicationException("incorrect password");
            }

        }
    }
}
