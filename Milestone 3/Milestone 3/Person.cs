using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_3
{
    class Person
    {
        //Fields
        private string _eyecolor;
        private string _haircolor;
        private string _skincolor;
        private double _phonenumber;
        private double _socialsecurity;
        private decimal _weight;

        //Constructor
        public Person(string eyecolor, string haircolor, string skincolor, double phonenumber, double socialsecurity, decimal weight)
        {
            _eyecolor = eyecolor;
            _haircolor = haircolor;
            _skincolor = skincolor;
            _phonenumber = phonenumber;
            _socialsecurity = socialsecurity;
            _weight = weight;
        }

        //eyecolor property
        public string Eyecolor
        {
            get { return _eyecolor; }
            set { _eyecolor = value; }
        }
        //haircolor property
        public string Haircolor
        {
            get { return _haircolor; }
            set { _haircolor = value; }
        }
        //skincolor property
        public string Skincolor
        {
            get { return _skincolor; }
            set { _skincolor = value; }
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
        public decimal Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
    }
}
