using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare your variables in one place
            int serialNo = 100;
            string accountNo = "";
            float anyNo = 4.8f;

            // accountNo = serialNo; *** cannot convert 'int' to 'string' (use a conversion method see example below) ***
            accountNo = serialNo.ToString();
            Console.WriteLine(accountNo);

            // serialNo = anyNo; *** cannot convert 'float' to 'int'
            serialNo = Convert.ToInt32(anyNo);
            Console.WriteLine(serialNo);
        }
    }
}
