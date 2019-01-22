using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adder
{
    public class AdderLogic : IAdder
    {
        public List<int> NumberList = new List<int>();
        public string Add(string value)
        {
            int IntegerValue = int.Parse(value);
            int sumValue = new int();
            
            NumberList.Add(IntegerValue);
            if (NumberList.Count == 1)
            {
                sumValue = NumberList[0];
            }
            else
            {
                for(int i = 0; i < NumberList.Count-1; i++)
                {
                    sumValue = NumberList[i] + NumberList[i+1];
                }
                
            }
            return sumValue.ToString();
            
        }

        public string Cancel()
        {
            NumberList.Clear();
            
            return "0";
            
        }

        public string GetNNumber0()
        {
            return ("0".ToString());
        }

        public string GetNNumber1()
        {
            return ("1".ToString());
        }

        public string GetNNumber2()
        {
            return ("2".ToString());
        }

        public string GetNNumber3()
        {
            return ("3".ToString());
        }

        public string GetNNumber4()
        {
            return ("4".ToString());
        }

        public string GetNNumber5()
        {
            return ("5".ToString());
        }

        public string GetNNumber6()
        {
            return ("6".ToString());
        }

        public string GetNNumber7()
        {
            return ("7".ToString());
        }

        public string GetNNumber8()
        {
            return ("8".ToString());
        }

        public string GetNNumber9()
        {
            return ("9".ToString());
        }

        public bool ResetCounter(int counter)
        {
            if (counter == 1)
            {
                counter = 0;
                return true;
            }
            return false;
        }
    }
}
