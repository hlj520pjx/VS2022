namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarMethod CM = new CarMethod();
            UserMethod UM=new UserMethod();

            string num = "";
            while (true)
            {
                tips();
                num =Console.ReadLine();

                switch (num)
                {
                    case "1":
                        Console.WriteLine("请输入车牌号");
                        string carnum=Console.ReadLine();
                        Console.WriteLine("请输入车辆类型");
                        string type = Console.ReadLine();
                        Console.WriteLine("请输入车辆小时费用");
                        string pay = Console.ReadLine();
                        string res=CM.Add(carnum, type, pay);
                        Console.WriteLine(res);
                        break;


                    case "2":
                        string res1=CM.SearchAll();
                        Console.WriteLine(res1);
                        break;


                    case "3":
                        Console.WriteLine("请输入Id");
                        string Id = Console.ReadLine();
                        string res2 = CM.SearchOne(Id);
                        Console.WriteLine(res2);
                        break;


                    case "4":
                        CM.SearchFree();
                        break;


                    case "5":
                        Console.WriteLine("请输入名字");
                        string name = Console.ReadLine();
                        Console.WriteLine("请输入身份证号");
                        string sf = Console.ReadLine();
                        Console.WriteLine("请输入性别");
                        string gen = Console.ReadLine();
                        Console.WriteLine("请输入电话号码");
                        string phonum = Console.ReadLine();
                        Console.WriteLine("请输入备注");
                        string moto = Console.ReadLine();
                        string res3 = UM.Add(name, sf, gen, phonum, moto);
                        Console.WriteLine(res3);
                        break;


                    case "6":
                        UM.SearchAll();
                        break;


                    case "7":
                        Console.WriteLine("请输入用户Id");
                        string id=Console.ReadLine();
                        UM.SearchOne(id);
                        break;


                    case "8":
                        Console.WriteLine("8：租车");
                        break;


                    case "9":
                        Console.WriteLine("9：换车");
                        break;



                    case "0":
                        Console.WriteLine("输入格式有误");
                        break;
                    default:
                        Console.WriteLine("9：换车");
                        break;
                }
            }




            static  void tips()
            {
                Console.WriteLine("             ==欢迎来到神车系统==               ");
                Console.WriteLine("                 请选择操作编号：                ");             
                Console.WriteLine("0：退出系统                   5：新增客户");                  
                Console.WriteLine("1：新增车辆                   6：查看所有客户");                   
                Console.WriteLine("2：查看所有车辆信息           7：查看某个客户");          
                Console.WriteLine("3：查看某辆车                 8：租车");                
                Console.WriteLine("4：查看所有空闲车辆           9：还车");
                Console.WriteLine("10：查看所有租车记录");

            }
        }
    }
}
