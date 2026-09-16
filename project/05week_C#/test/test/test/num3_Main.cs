using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace test
{
    internal class num3_Main
    {
        

        static void Main(string[] args)
        {
            Employee MD = new Employee(1,"","",10.1);
           

            string num = "";
            while (num!= "6")
            {
                tips();
                num = Console.ReadLine();
                switch (num)
                {
                    case "1":
                        Console.WriteLine("请输入员工编号：");
                        string EmpIdStr = Console.ReadLine();
                        var regId = @"^[1-9]\d*$"; // 正整数，首位非0
                        if (!Regex.IsMatch(EmpIdStr, regId))
                        {
                            Console.WriteLine("输入的员工ID有误（必须为正整数）");
                            break;
                        }
                        int EmpId = int.Parse(EmpIdStr);

                        Console.WriteLine("请输入员工名字：");
                        string EmpName = Console.ReadLine();

                        Console.WriteLine("请输入员工部门：");
                        string Department = Console.ReadLine();

                        Console.WriteLine("请输入员工薪资：");
                        string SalaryStr = Console.ReadLine();
                        var regSalary = @"^\d+(\.\d{1,2})?$"; // 正数，最多两位小数
                        if (!Regex.IsMatch(SalaryStr, regSalary))
                        {
                            Console.WriteLine("输入的员工薪资有误（必须为正数，小数最多两位）");
                            break;
                        }
                        double Salary = double.Parse(SalaryStr);

                        string res = MD.Add(EmpId, EmpName, Department, Salary);
                        Console.WriteLine(res);
                        break;

                    case "2":
                        MD.SearchAll();
                        break;

                    
                    case "3":
                        Console.WriteLine("请输入员工Id：");
                        string id = Console.ReadLine();
                        Console.WriteLine("请输入员工薪资：");
                        string money1 = Console.ReadLine();
                        double salary = double.Parse(money1);
                        MD.adpmoney(id, salary);
                        break;

                    case "4":
                        Console.WriteLine("请输入员工Id：");
                        string id1 = Console.ReadLine();
                        MD.del(id1);
                        break;

                    case "5":
                        Console.WriteLine("请输入薪资大小：");
                        double hope = double.Parse(Console.ReadLine());
                        MD.getmoney(hope);
                        break;

                    case "6":
                        Console.WriteLine("6：退出系统");
                        break;

                }






            }


            static void tips()
            {
                Console.WriteLine("员工薪资管理控制台系统");
                Console.WriteLine("请按1-6来操作系统");
                Console.WriteLine("1：新增员工（增）");
                Console.WriteLine("2：查看全部员工（查-全部）");
                Console.WriteLine("3：根据编号调整薪资（改）");
                Console.WriteLine("4：根据编号删除员工（删）");
                Console.WriteLine("5：按薪资条件筛选员工（查-条件）");
                Console.WriteLine("6：退出系统");
            }
            

        }
    }
}
