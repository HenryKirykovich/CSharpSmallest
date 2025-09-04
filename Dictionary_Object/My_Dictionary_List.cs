using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    internal class My_Dictionary_List
    {

        public Dictionary<string, string> LFName { get; set; } // declaring simple Dictionary 

        public Dictionary<int, Dictionary<string, string>> home { get; set; } // declaring Dictionary included first Dictionary for chaining  any number ( int to string inside second Dictionary  
        

    }

    
}
