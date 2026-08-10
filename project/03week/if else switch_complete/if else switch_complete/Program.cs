using System;

namespace if_else_switch_complete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("请输入资产：");
            int money=int.Parse(Console.ReadLine());
            Console.WriteLine("请输入颜值：");
            double yanzhi = double.Parse(Console.ReadLine());
            bool m = money >300 || yanzhi > 9.5;
            Console.WriteLine(m);*/

            /*Console.WriteLine("小红年龄：");
            int age = int.Parse(Console.ReadLine());
            bool n = age > 16 && age < 25;
            Console.WriteLine(n);*/



            /*Console.WriteLine("请输入成绩:");
            int sum = int.Parse(Console.ReadLine());
            if (sum < 60)
            { Console.WriteLine($"{sum}不及格"); }
            else if (sum > 60 && sum < 80)
            { Console.WriteLine($"{sum}及格"); }
            else if (sum > 80 && sum < 90)
            { Console.WriteLine($"{sum}良好"); }
            else if (sum > 90 && sum < 100)
            { Console.WriteLine($"{sum}优秀"); }
            else if (sum == 100)
            { Console.WriteLine($"{sum}满分"); }
            else
            { Console.WriteLine($"{sum}分数错误"); }*/




            /*Console.WriteLine("请输入年份:");
            int year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine($"{year}是闰年");
            }
            else
            {
                Console.WriteLine($"{year}不是闰年");
            }*/



            /*Console.WriteLine("请输入数字:");
            int num = int.Parse(Console.ReadLine());
            switch (num) 
            {
                case 1: Console.WriteLine("星期一");break;
                case 2: Console.WriteLine("星期二"); break;
                case 3: Console.WriteLine("星期三"); break;
                case 4: Console.WriteLine("星期四"); break;
                case 5: Console.WriteLine("星期五"); break;
                case 6: Console.WriteLine("星期六"); break;
                case 7: Console.WriteLine("星期天"); break;
                default: Console.WriteLine("请重新输入"); break;

            }*/


            /*Console.WriteLine("请输入分数:");
            int score = int.Parse(Console.ReadLine());
            int n = score / 10;
            switch (n)
            {
                case 1:
                    Console.WriteLine($"{score}分为F级");
                    break;
                case 2:
                    Console.WriteLine($"{score}分为F级");
                    break;
                case 3: 
                    Console.WriteLine($"{score}分为F级");
                    break;
                case 4: 
                    Console.WriteLine($"{score}分为F级");
                    break;
                case 5: 
                    Console.WriteLine($"{score}分为F级");
                    break;
                case 6: 
                    Console.WriteLine($"{score}分为D级");
                    break;
                case 7:
                    Console.WriteLine($"{score}分为C级"); 
                    break;
                case 8: 
                    Console.WriteLine($"{score}分为B级");
                    break;
                case 9:
                    Console.WriteLine($"{score}分为A级");
                    break;
                case 10:
                    Console.WriteLine($"{score}分为A级");
                    break;
               
                default: Console.WriteLine("请重新输入"); break;

            }*/

            //穿透写法
            /*Console.WriteLine("请输入数字:");
           int num = int.Parse(Console.ReadLine());
           switch (num) 
           {
               case 1: Console.WriteLine("星期一");break;
               case 2: Console.WriteLine("星期二"); break;
               case 3: Console.WriteLine("星期三"); break;
               case 4: Console.WriteLine("星期四"); break;
               case 5: Console.WriteLine("星期五"); break;
               case 6: 
               case 7: Console.WriteLine("周末"); break;
               default: Console.WriteLine("请重新输入"); break;

           }*/


            //switch简写
            /*Console.WriteLine("请输入分数:");
            int score = int.Parse(Console.ReadLine());
            string res = score switch
            {
                >= 90 => "A",
                >= 80 => "B",
                >= 70 => "C",
                >= 60 => "D",
                _=>"F"

            };
            Console.WriteLine(res);*/



            /*Console.WriteLine("请输入年龄:");
            int age = int.Parse(Console.ReadLine());
            string aa = age > 18 ? "成年" : "未成年";
            Console.WriteLine(aa);*/


            /* Console.WriteLine("请输入年份:");
             int year = int.Parse(Console.ReadLine());
             string bb = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0 ? "闰年" : "平年";
             Console.WriteLine(bb);*/

            //**********************************************************************************************************
            //作业1
            /*string zh="admin",mm="123456";
            Console.WriteLine("请输入账号：");
            string n1= Console.ReadLine();
            Console.WriteLine("请输入密码：");
            string n2 = Console.ReadLine();
            if (zh==n1&&mm==n2) Console.WriteLine("登录成功");
            else if (zh != n1 && mm == n2) Console.WriteLine("账号不存在！");
            else if (zh != n1 && mm != n2) Console.WriteLine("账号不存在！");
            if (zh == n1 && mm != n2) Console.WriteLine("密码错误！");*/



            //作业2  用了switch简写
            /*Console.WriteLine("选择菜单（add/edit/del）");
            string a1=Console.ReadLine();
            string res= a1 switch
            { 
                "add"=>"新增成功",
                "edit" => "编辑成功",
                "del" => "删除成功",
                _=>"操作失败！"
            };
            Console.WriteLine(res);*/



            //作业3
            /*Console.WriteLine("请问您是VIP/USER:");
            string name=Console.ReadLine();
            Console.WriteLine("您消费的金额是:");
            double money=double.Parse(Console.ReadLine());
            double res;
            if (name=="VIP") 
            {
                if (money >= 1000)
                {
                    res = money * 0.9;
                }
                else
                {
                    res = money;
                }
            } 
            else 
            {
                if (money >= 2000)
                {
                    res = money * 0.95;
                }
                else
                {
                    res = money;
                }
            }
            Console.WriteLine(res);*/



            //作业4
            /* Console.WriteLine("请输入月份：");
             int month = int.Parse(Console.ReadLine());
             switch (month)
             {
                 case 3:
                 case 4:
                 case 5: Console.WriteLine($"{month}月是春季"); break;

                 case 6:
                 case 7:
                 case 8: Console.WriteLine($"{month}月是夏季"); break;

                 case 9:
                 case 10:
                 case 11: Console.WriteLine($"{month}月是秋季"); break;

                 case 12:
                 case 1:
                 case 2: Console.WriteLine($"{month}月是冬季"); break;
                 default: Console.WriteLine("请重新输入"); break;
         }*/



            //作业5
            /*Console.WriteLine("请输入重量(g)");
            double weigth=double.Parse(Console.ReadLine());
            double res = weigth / 1000;
            if(res<1) Console.WriteLine("快递费10元");
            else if(res>1&&res<5) Console.WriteLine("快递费20元");
            else  Console.WriteLine("快递费50元");*/


            //作业6
            /* Console.WriteLine("请输入会员等级：");
             int res=int.Parse(Console.ReadLine());
             if (res > 2)
             {
                 switch (res)
                 {
                     case 3: Console.WriteLine("输出购物打9折"); break;
                     case 4: Console.WriteLine("每月可领优惠券"); break;
                     case 5: Console.WriteLine("终身免运费"); break;
                     default: Console.WriteLine("请重新输入"); break;
                 }
             }
             else Console.WriteLine("抱歉无任何福利");*/



            //作业7
            /*Console.WriteLine("请输入商品编号整数：");
            int res = int.Parse(Console.ReadLine());
                switch (res)
                {
                    case 1: Console.WriteLine("已购买可乐"); break;
                    case 2: Console.WriteLine("已购买雪碧"); break;
                    case 3: Console.WriteLine("已购买矿泉水"); break;
                    default: Console.WriteLine("无此商品"); break;
                }*/


            //作业8
           /* Console.WriteLine("请输入当前速度：");
            int res = int.Parse(Console.ReadLine());
            if (res < 30) Console.WriteLine("低速通过");
            else if (res >= 30 && res < 60) Console.WriteLine("中速通过");
            else if (res >= 60 && res < 100) Console.WriteLine("高速通过");
            else if (res >= 100 && res < 120) Console.WriteLine("高速通过");
            else Console.WriteLine("您已超速");*/




        }
    }
}
