using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adder
{
    interface IAdder
    {
        string GetNNumber1();
        string GetNNumber2();
        string GetNNumber3();
        string GetNNumber4();
        string GetNNumber5();
        string GetNNumber6();
        string GetNNumber7();
        string GetNNumber8();
        string GetNNumber9();
        string GetNNumber0();
        string Add(string value);
        string Cancel();
        bool ResetCounter(int countervalue);


    }
}
