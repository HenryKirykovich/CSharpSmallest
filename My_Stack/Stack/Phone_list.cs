namespace My_Stack.Stack
{
    internal class Phone_list
    {
		private string first_Name;

		public string First_Name
		{
			get { return first_Name; }
			set { first_Name = value; }
		}

        private string last_Name;

        public string Last_Name
        {
            get { return last_Name; }
            set { last_Name = value; }
        }

        private string number;

        public string Number
        {
            get { return number; }
            set { number = value; }
        }


        public Phone_list()
        {
            
        }

        public Phone_list(string _First_Name, string _Last_Name, string _Number)
        {
            First_Name = _First_Name;
            Last_Name = _Last_Name;
            Number = _Number;
        }
    }
}
