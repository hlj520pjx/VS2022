using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace test
{
    internal class num2
    {
        
        static void main(string[] args)
        {
            string[] Arr = ["   18253426445   ", "   oiugASDHJGTDfg894519   ", "   149562397461946956   ", "     154455    ", "  15496485334    "];
            string[] aaa = new string[5];
            string[] bbb = new string[5];
            for (int i = 0; i < Arr.Length; i++)
            {
                aaa[i] = Arr[i].Trim();  
            }
            for (int j = 0; j < aaa.Length; j++)
            {
                bbb[j] = aaa[j].ToLower();
            }
            var reg = @"\D";
            var reg1 = @"^[1][3,4,5,7,8]\d{9}$";
            foreach(var item in bbb)
            {
                bool res = Regex.IsMatch(item, reg);
                bool res1 = Regex.IsMatch(item, reg1);
                if (!res)
                {
                    if (res1)
                    {
                        Console.WriteLine($"{item}为合法手机号");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine($"{item}为非法手机号");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine($"{item}为普通文本");
                    Console.WriteLine();
                }
                    
                 
            }
            





        }

    }
}
