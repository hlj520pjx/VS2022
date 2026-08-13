using System.Collections;
using System.Collections.Generic;
using System.Text.Json;

namespace _04week04day
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*var fn = (int n1, int n2, params int[] args) =>
            {
                //Console.WriteLine(n1 + n2);
                foreach (var item in args) Console.Write(item + " ");
                Console.WriteLine();
            };

            fn(10, 20);
            fn(10, 20, 30);//前两个是n1、n2的值，第三个才是args的形参
            fn(10, 20, 30, 40);//前两个是n1、n2的值，第三、四个才是args的形参*/


            //params可变参数可以允许定义一个数组而放进入无数个形参
            /*var num = (params int[] a) =>
            {
                int sum = 0;
                foreach (int item in a)
                {
                    sum += item;
                }
                return sum;
            };
            int aa=num(3, 5, 8, 9, 4);
            Console.WriteLine(aa);*/


            //元组
            /* var a = (1, 1.23, true, "fdv5");
             Console.WriteLine(a.Item1);
             Console.WriteLine(a.Item2);
             Console.WriteLine(a.Item3);
             Console.WriteLine(a.Item4);*/

            //var singleTuple = (1,);


            List<Dictionary<string, dynamic>> list = new() {
    new Dictionary<string, dynamic>(){
        ["name"] = "zs",
        ["age"] = 29,
        ["isMan"] = true,
        ["isSingle"] = true,
        ["salary"] = 4200
    },
    new Dictionary<string, dynamic>(){
        ["name"] = "ls",
        ["age"] = 20,
        ["isMan"] = false,
        ["isSingle"] = true,
        ["salary"] = 3400
    },
    new Dictionary<string, dynamic>(){
        ["name"] = "ww",
        ["age"] = 19,
        ["isMan"] = true,
        ["isSingle"] = false,
        ["salary"] = 6000
    },
    new Dictionary<string, dynamic>(){
        ["name"] = "zl",
        ["age"] = 14,
        ["isMan"] = false,
        ["isSingle"] = true,
        ["salary"] = 2000
    },
    new Dictionary<string, dynamic>(){
        ["name"] = "sq",
        ["age"] = 35,
        ["isMan"] = true,
        ["isSingle"] = false,
        ["salary"] = 7000
    },
    new Dictionary<string, dynamic>(){
        ["name"] = "zb",
        ["age"] = 27,
        ["isMan"] = false,
        ["isSingle"] = true,
        ["salary"] = 2900
    },
};

            // 作业1
            // 找第一个满足条件的元素Find: 要求查找年龄小于20的
            /*var res = list.Find(item =>
            {
                return item["age"] < 20;

            });
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            Console.WriteLine(JsonSerializer.Serialize(res, options));
            Console.WriteLine($"{res["age"]}");*/




            // 找最后一个满足条件的元素FindLast: 要求查找年龄大于25的
            /*var res1 = list.FindLast(item =>
            {
                return item["age"] > 25;

            });
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            Console.WriteLine(JsonSerializer.Serialize(res1, options));*/



            // 找所有满足条件的元素FindAll: 找出性别男的
            /*var res2 = list.FindAll(item =>
            {
                return item["isMan"]=true;

            });
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            Console.WriteLine(JsonSerializer.Serialize(res2, options));*/





            // 找第一个满足条件的元素下标FindIndex: 找出薪水大于5000
            /*var res3 = list.FindIndex(item =>
            {
                return item["salary"]> 5000;

            });
            Console.WriteLine(res3);*/




            // 找最后一个满足条件的下标FindLastIndex: 找出薪水小于3000
            /*var res4 = list.FindLastIndex(item =>
            {
                return item["salary"] < 3000;

            });
            Console.WriteLine(res4);*/



            // Exists: 判断是否有薪水大于5000
            /*var res5 = list.Exists(item =>
            {
                return item["salary"] > 5000;

            });
            Console.WriteLine(res5);*/



            // ForEach: 输出每个的 名字-年龄-薪水
            /*list.ForEach((item) =>
             {
                 Console.WriteLine($"名字：{item["name"]}  年龄{item["age"]}  薪水{item["salary"]}");
             });*/



            // ConvertAll: 映射得到一个所有薪水的list
            /*List<dynamic> newList = list.ConvertAll(item =>
            {
                return item["salary"];
            });
            foreach (dynamic item in newList)
            {
                Console.WriteLine(item);
            }*/

            //TrueForAll: 判断是否都成年
            /*var res6 = list.TrueForAll(item =>
            {
                return item["age"] > 18;

            });
            if (res6==true) Console.WriteLine("全都成年");
            else Console.WriteLine("有未成年");*/



            //作业2: 封装一个函数 接收一个字符串; 返回一个字典,键是字符串的每个字符,键值是这个字符在字符串中出现的次数
            string Str = "dsgfgasfgncvcx";
            var fn = (string str) =>
            {
                var hlj = new Dictionary<char, int>();
                foreach (char c in str)
                {
                    if (hlj.ContainsKey(c))
                    {

                        hlj[c]++;
                    }
                    else
                    {

                        hlj.Add(c,1);
                    }
                }
                return hlj;
            };

            var options = new JsonSerializerOptions//序列化美化
            {
                WriteIndented = true
            };
            Console.WriteLine(JsonSerializer.Serialize(fn(Str), options));





















        }
    }
}
