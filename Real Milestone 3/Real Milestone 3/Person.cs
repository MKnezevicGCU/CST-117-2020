using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Milestone_3
{
    class Person
    {
        //Fields
        private string _firstname;
        private string _lastname;
        private string _address;
        private double _phonenumber;
        private double _socialsecurity;
        private int _personid;

        //Constructor
        public Person(string firstname, string lastname, string address, double phonenumber, double socialsecurity, int personid)
        {
            _firstname = firstname;
            _lastname = lastname;
            _address = address;
            _phonenumber = phonenumber;
            _socialsecurity = socialsecurity;
            _personid = personid;
        }

        //eyecolor property
        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
        //haircolor property
        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
        //skincolor property
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        //phonenumber property
        public double Phonenumber
        {
            get { return _phonenumber; }
            set { _phonenumber = value; }
        }
        //social security property
        public double Socialsecurity
        {
            get { return _socialsecurity; }
            set { _socialsecurity = value; }
        }
        //weight property
        public int Personid
        {
            get { return _personid; }
            set { _personid = value; }
        }
    }
}
