using System;


namespace TestSummer
{

    public class ValidInput
    {
        public static byte Convert(string number)
        {
            byte parsedValue;
            bool ok = byte.TryParse(number, out parsedValue);
            if (ok == true && parsedValue > 0 && parsedValue < 99)
            {
                return parsedValue;
            }
            else if (ok == true && parsedValue == 0)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 10.");
                return 99; // Indicates invalid input

            }
           

        }
    }

}
