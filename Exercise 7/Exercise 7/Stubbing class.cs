using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Stubbing_class
    {
        private int Sum(int num1, int num2)
        {
            int result = 0;
            ///
            //result = num1 + num2;
            return result;
        }

        private double Average(double num1, double num2, double num3, double num4, double num5)
        {
            
        }

        private int Sum(int num1, int num2)
        {

        }

        private int Sum(int num1, int num2, int num3)
        {

        }
        private string DisplayLessCharacters(string name, string age)
        {

        }
        private List<double> LargestArrayValue(double[] num1, double[] num2)
        {

        }
        private List<int> ReturnArray()
        {
            List<int> result = new List<int>();
            for( int i =0; i < 50; i++)
            {
                result.Add(i);
            }
            return result;
        }
        private bool ReturnBoolVariable(int num1, int num2)
        {

        }
        private int double ReturnAnswer(int num1, double num2)
        {

        }
        private int AverageArray(int[] num1, int[] num2, int[] num3)
        {

        }
    }
}
