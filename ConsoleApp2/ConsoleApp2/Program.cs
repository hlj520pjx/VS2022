namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*dynamic a = 12.2;//dunamic 变量的值可以变为不同类型的值
            Console.WriteLine($"a={a}");
            a = "ashck445";
            Console.WriteLine($"a={a}");
            a = true;
            Console.WriteLine($"a={a}");*/


            /*var b = 12;
            b = "erew551";//无法更改var类型的值，会报错*/

            //变量名.GetType()可以查看变量的类型
            /*int c = 10;
            Console.WriteLine(c.GetType());
            double d = 12.23;
            Console.WriteLine(d.GetType());
            string e = "sf54";
            Console.WriteLine(e.GetType());
            bool f=true;
            Console.WriteLine(f.GetType());*/



            /*var user1 = new
            {
                name = "pjx",
                age = 22,
                lover = "hlj",
                isman=true
            };
            //Console.WriteLine(user1.GetType());不能直接查看匿名对象的格式，会报错
            Console.WriteLine(user1.name);
            //user1.name = "dff";无法更改名字*/



           //数据字典
           Dictionary<string,dynamic>user=new Dictionary<string,dynamic>()
           {
               ["name"]="pjx",
               ["age"]=23,
               ["isman"]=false,
               ["boyfriend"]=new Dictionary<string, dynamic>()
               {
                   ["name"] = "hlj",
                   ["age"] = 22,
                   ["isman"] = true,
               }
           };
            //Console.WriteLine(user["name"]);
            //Console.WriteLine(user["boyfriend"]["name"]);
            //Console.WriteLine(user.TryGetValue("name",out dynamic val));//查找该键名是否存在
            //数据字典就是具有某种特征的集合，里面有各种变量的元素

            /*Console.WriteLine(user.Count);
            user["boyfriend"]["name"] = "cfj";
            Console.WriteLine(user["boyfriend"]["name"]);*/
            //数据字典里面内容可更改

            //user["height"] = 180;
            //Console.WriteLine(user["height"]);//添加内容
            //user.Remove("name");//删除内容
            //Console.WriteLine(user.TryGetValue("name",out dynamic val ));


            //user.Clear();//清除全部的数据字典内容
            //Console.WriteLine(user.TryGetValue("name", out dynamic val));
            //Console.WriteLine(user.TryGetValue("age", out dynamic va));

            //普通数组的两种格式
            //int[] arr = new int[3];
            //Console.WriteLine(arr[2]);
            //int [] arr2 = {10,20,30};
            //arr2[1] = 40;//修改
            //Console.WriteLine(arr2[1]);
            //Console.WriteLine(arr2.Count());
            //string[] arr3 = {"i","l","y" };
            //Console.WriteLine(arr3[1]);



            List<string> man = new List<string>()
            {
               "张三",
               "李四",
               "王五",
               "老六"
            };
            Console.WriteLine(man[1]);
            man[1] = "田七";
            Console.WriteLine(man[1]);
            Console.WriteLine(man.Count);
            man.Add("pjx");
            Console.WriteLine(man[4]);
            man.AddRange(new List<string>() { "cfj", "xzc", "hlj" });
            Console.WriteLine(man[6]);


            

        }
    }
}
