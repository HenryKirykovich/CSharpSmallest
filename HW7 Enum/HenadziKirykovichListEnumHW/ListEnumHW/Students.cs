using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListEnumHW
{
    public abstract class Students
    {
        private string lastName;
		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

    }


    public enum ClassSize
    {
        Large,
        VeryLarge,
        ExtremelyLarge
    }

    public enum Color
    {
        red,
        blue,
        green
    }

    public class GradeSchool : Students
	{

		public ClassSize Size { get; set; }
        
		public Color FavoriteColor { get; set; }

		

				
		public GradeSchool(Color pColor,  string pLastName)
		{
			this.FavoriteColor = pColor;
			this.LastName = pLastName;
            this.Size = ClassSize.Large;
        }
		public GradeSchool()
		{
			
		}
    }

	public class HighSchool : Students
	{
        public ClassSize Size { get; set; }

        public Color FavoriteColor { get; set; }

        public HighSchool(Color pColor, string pLastName)
        {
            this.FavoriteColor = pColor;
            this.LastName = pLastName;
            this.Size = ClassSize.VeryLarge;
        }
        public HighSchool()
        {
            
        }
    }

   public class College : Students
    {
        public ClassSize Size { get; set; }

        public Color FavoriteColor { get; set; }

        public College(Color pColor, string pLastName)
        {
            this.FavoriteColor = pColor;
            this.LastName = pLastName;
			this.Size = ClassSize.ExtremelyLarge;
        }
        public College()
        {

        }

    }




}
