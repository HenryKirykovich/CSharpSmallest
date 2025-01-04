using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Using_Delegate_for_carrier_Method_Event
{
    public class Accounts   // declare fields
    {
        


        private string firstName { get; set; }
        private string lastName { get; set; }
        private int valueMoney { get; set; }


        public Accounts(string _firstName, string _lastName, int _valueMoney)   // declare constructor
        {
            firstName = _firstName;
            lastName = _lastName;
            valueMoney = _valueMoney;
        }

        //public static string PrintManyArguments(string FirstName, string LastName, int ValueMoney)   // declare method that we would like to invoke by Delegate
        //{
        //    return $"Dear, {FirstName} {LastName} you have in your account is ${ValueMoney}";
        //}


        public static string PrintOneObject(Accounts accounts) // declare method that we would like to invoke by Delegate
        {
            return $"Dear, {accounts.firstName} {accounts.lastName} you have in your account is ${accounts.valueMoney}";
        }


        public static void PrintList(List<Accounts> list_account) // declare method that we would like to invoke by Delegate
        {

            foreach (var item in list_account)
            {
                Console.WriteLine($"Dear, {item.firstName} {item.lastName} you have in your account is ${item.valueMoney}");
            }
            
            
        }
    }
}
