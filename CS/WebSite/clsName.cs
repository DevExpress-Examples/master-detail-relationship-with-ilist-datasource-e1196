using System;
using System.Collections.Generic;
using System.Text;


    public class clsName
    {
        private string _Code = "";
        private string _FirstName = "";
        private string _LastName = "";

        public clsName(string code, string firstName, string lastName)
        {
            _Code = code;
            _FirstName = firstName;
            _LastName = lastName;
        }

        public string Code
        {
            get { return _Code; }
        }

        public string FirstName
        {
            get { return _FirstName; }
        }

        public string LastName
        {
            get { return _LastName; }
        }
}
