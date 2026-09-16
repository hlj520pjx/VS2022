using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace test
{
    internal class num3_Main
    {
        

        static void Main(string[] args)
        {
            Method MD = new Method();
           

            string num = "";
            while (num!= "6")
            {
                tips();
                num = Console.ReadLine();
                switch (num)
                {
                    case "1":
                        Console.WriteLine("请输入员工名字：");
                        string name= Console.ReadLine();
                        Console.WriteLine("请输入员工部门：");
                        string part = Console.ReadLine();
                        Console.WriteLine("请输入员工薪资：");
                        double money = double.Parse(Console.ReadLine());
                        string res=MD.Add(name, part, money);
                        Console.WriteLine(res);

                        break;

                    case "2":
                        MD.SearchAll();
                        break;

                    case "3":
                        Console.WriteLine("请输入员工Id：");
                        string id = Console.ReadLine();
                        Console.WriteLine("请输入员工薪资：");
                        double money1 = double.Parse(Console.ReadLine());
                        MD.adpmoney(id, money1);
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
