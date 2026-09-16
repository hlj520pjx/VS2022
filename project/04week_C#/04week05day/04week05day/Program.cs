using System.IO;

namespace _04week05day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //读取文件内容
            /*var path = "C:\\Users\\27660\\Desktop\\1视觉02培训资料\\第四周\\8.14星期五\\111.txt";//绝对路径读取
            var path1 = @"C:\Users\27660\\Desktop\1视觉02培训资料\第四周\8.14星期五\111.txt";
            var res=File.ReadAllText(path1);
            Console.WriteLine(res);*/


            //写入文件内容，会覆盖原有内容
            /*var path2 = @"C:\Users\27660\\Desktop\1视觉02培训资料\第四周\8.14星期五\111.txt";
            File.WriteAllText(path2,"hello");*/


            //追加文本，不会覆盖原有内容
            /*var path3 = @"C:\Users\27660\\Desktop\1视觉02培训资料\第四周\8.14星期五\111.txt";
            File.AppendAllText(path3, "\nhello111122222");*/


            var path3 = "./111.txt";

            //判断文件是否存在
            /*bool exist=File.Exists(path3);
            Console.WriteLine(exist);*/

            //实现写日志
            /*var writelog = (string path) =>
             {
                 var date= DateTime.Now.ToString();
                 File.AppendAllText(path, date);

             };
             writelog(path3);*/

            /*Action writelog = () =>
            {
                Console.WriteLine("请执行操作：");
                string res=Console.ReadLine();
                var date = DateTime.Now;
                File.AppendAllText("./ 222.log", $"{res}---{date}");

            };
            writelog();*/

            //找文件是否存在
            /* bool isexist = File.Exists("./data");
             Console.WriteLine(isexist);*/

            //找文件夹是否存在
            /*bool isexist =Directory.Exists("./data");
            Console.WriteLine(isexist);*/

            //Directory.CreateDirectory("./data/666");

            //Directory.Delete("./data");

            //Directory.Delete("./data", true);

            /* string[] files=Directory.GetFiles("./");
             foreach (string file in files)
             {
                 Console.WriteLine(file);
             }*/

            /*string[] files = Directory.GetDirectories("./");
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }*/


            /*string[] files = Directory.GetDirectories("./","*",SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }*/


            //案例：判断一个路径是文件还是文件夹
            /* var path = "./111.txt";
             Func<string, int> res = path =>
             {
                 if (File.Exists(path)) return 1;
                 if (Directory.Exists(path)) return 2;
                 return 0;

             };
             int result = res(path);
             string[] arr = ["两个都不是", "文件", "文件夹"];
             Console.WriteLine(arr[result]);*/


            //案例：获取目录下所有目录和文件（一级）
            /*Func<string, List<string>> fliedir = path =>
            {
                List<string> list = new List<string>();
                if (Directory.Exists(path) != true) throw new Exception("请输入正确的目录地址");

                string[] flies = Directory.GetFiles(path);
                list.AddRange(flies);
                string[] dir = Directory.GetDirectories(path);
                list.AddRange(dir);
                return list;
            };
            var res = fliedir("./");
            foreach (var f in res) Console.WriteLine(f);*/


            //作业: 使用读写文件配合命令行窗口 模拟实现注册功能

            //要求输入用户名和密码,完成注册; (注册的用户信息记录在user.txt文件中, 一行一个用户信息 数据之间通过 === 分隔)

            Console.WriteLine("请输入账号");
            string zh = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string mm = Console.ReadLine();

            Func<string, string, string, string> res = (zh1, mm1, adr) =>
            {
                string text = File.ReadAllText(adr);
                if (text.Contains($"账号：{zh1}==密码：{mm1}"))
                {
                    Console.WriteLine("账户已存在");
                }
                else
                {
                    File.AppendAllText(adr, $"账号：{zh1}==密码：{mm1}{Environment.NewLine}");
                    Console.WriteLine("注册成功！");

                }

                return text;
            };
            res(zh, mm, "./user.txt");



            /* 扩展练习: 使用读写文件配合命令行窗口 模拟实现注册登录功能

             进入就是菜单栏界面, 1注册,2登录,0退出

             输入1 进入注册, 要求输入用户名,密码, 用户输入用户名和密码 则实现注册功能, 要求校验用户名和密码

             输入2 进入登录, 要求输入用户名, 密码, 输入后完成登录校验功能; 登录成功提示 登录成功

             输入0 退出程序,

             -用户注册成功的用户信息 以文件的形式存储在user.json中(要求以json形式存储)
               - [{ username: "",password: "",datetime: "时间戳"}]
               -用户操作日志user.log: 用户每次操作都要有日志记录, 记录操作,用户名,操作方式,时间,如果有异常的,记录异常*/












        }
    }
}
