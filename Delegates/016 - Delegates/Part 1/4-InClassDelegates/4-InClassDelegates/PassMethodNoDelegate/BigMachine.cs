using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassMethodNoDelegate
{
  
    class BigMachine
    {
            
        // here we specify that the method accepts one parameter, and the data type is Directions
            
        public void GiveMeDirections(int Count, string theWord, DirectionsDelagate passedInMethod) 
        {
         
            passedInMethod(Count, theWord);
          
           
        }
    }
}
