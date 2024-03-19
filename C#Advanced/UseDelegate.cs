using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced
{
    internal class UseDelegate
    { 
        delegate int CalculateDelegate(int num1, int num2);
        
        public static void CallDelegate()
        {
            int num1 = 10;
            int num2 = 5;
            CalculateWithDelegate(num1, num2, Add);
            CalculateDelegate dlg = Subtract;
            CalculateWithDelegate(num1, num2, dlg);
            CalculateWithDelegate(num1, num2, delegate (int num1, int num2) { return num1 + num2; });
            CalculateWithDelegate(num1, num2, (num1, num2) => num1 + num2);

        }

        static void CalculateWithDelegate(int num1, int num2,CalculateDelegate dlg)
        {
            int result = dlg(num1, num2);
            Console.WriteLine($"Result = {result}");
        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Subtract(int num1,int num2)
        {
            return num1 - num2;
        }
    }
}
