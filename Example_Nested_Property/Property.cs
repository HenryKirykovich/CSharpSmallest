using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Nested_Property
{
    class Property     // nested property (object) for next level property Coordinate
    {
        public float height { get; set; }
        public float width { get; set; }

        // // default constructor 
        public Property() { }

        // Constructor with parameters
        public Property(float _height, float _width)
        {
            height = _height;
            width = _width;
        }

    }


    class Coordinate  //  object accumulated property from Property class
    {

        public Property point { get; set; }  // declaration 

        public Coordinate()    // default constructor 
        {
            Property point = new Property();

            point.height = 0;
            point.width = 0;
        }

        public Coordinate(float _height, float _width)  // constructor for accessing to property 
        {
            Property point = new Property(_height,_width);
            
        }
    }






}
