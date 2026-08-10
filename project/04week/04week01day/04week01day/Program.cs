using System.Text.RegularExpressions;

namespace _04week01day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*// 敏感词替换为 * , 而且个数要保持一致
            string str = "生活总会有大麻烦, 黑夜总会过去";
            // 假设list存储敏感词
            List<string> mgc = ["大麻", "夜总会"];

            foreach (string str1 in mgc) 
            {
                string newstr = "";
                for (int i = 0; i < str1.Length; i++)
                newstr += "*";
                str = str.Replace(str1, newstr);


            }
            Console.WriteLine(str);*/



            //例：`"you love i"`转成`"I Love You"`
            /*string res1 = "you love i";

            string[] res2= res1.Split();

            List<string> reslist = new ();

            foreach (string str in res2)
            {
                reslist.Add(str);
            }
            reslist.Reverse();

            string resstr = "";
            foreach (string item in reslist)
            {
                string first=item.Substring(0,1).ToUpper();
                string other=item.Substring(1).ToLower();
                resstr += first+other+" ";
            }
            Console.WriteLine(resstr);

            Console.WriteLine(resstr.Substring(0,resstr.Length-1));//去掉空格处理*/


            //字符串去重1
            /*string str = "abcedgjjjsssabcd";
            string resStr = ""; // 去重后的字符串

            for (int i = 0; i < str.Length; i++)
            {
                int j = 0;
                for (;j < resStr.Length; j++)//j=0<0,false跳到下一个循环
                {
                    if(str[i] ==resStr[j])break;
                }


                if (j == resStr.Length) resStr += str[i];
            }

            Console.WriteLine(resStr);*/


            //字符串去重2
            /*string str = "abcedgjjjsssabcd";
            string resStr = ""; // 去重后的字符串
            foreach (char str2 in str)
            {
                if(!resStr.Contains(str2))
                    resStr += str2;
            }
            Console.WriteLine(resStr);*/


            /*string str = "abcDDDDefg";
            Console.WriteLine(str.ToUpper()); // ABCDDDDEFG
            Console.WriteLine(str.ToLower()); // abcddddefg   */


            // 字符串.Split(指定分隔符)
            //string str = "西瓜_葡萄_芒果_榴莲";
            //string[] arr= str.Split("_");
            //foreach (string item in arr)
            //Console.WriteLine(item);

            //string str = "西瓜_葡萄_芒果_榴莲";
            //string[] arr = str.Split("_");
            //foreach (string item in arr)
            //    Console.WriteLine(item);



            //string str1 = "aa";
            //string str2 = "bb";
            //string str3 = "cc";
            //string res=string.Concat(str1, str2, str3);
            //Console.WriteLine(res);

            //List<string> strList = ["I", "Love", "U"];
            //string[] strArr = ["qq", "ww", "EE"];
            //Console.WriteLine(string.Join("-",strArr));
            //Console.WriteLine(string.Join("*", strList));


            /*//正则提取
            string reg = @"b";
            string str = "bac";
            //  Regex.Match(字符串,正则规则);  // 按照规则从字符串中提取内容
            Match res = Regex.Match(str, reg);
            Console.WriteLine(res.Value); // a

            bool n1=Regex.IsMatch("bc", reg);
            Console.WriteLine(n1);
            string n2 = Regex.Replace("abbd", reg, "c");
            Console.WriteLine(n2);*/


            /*var reg = @"^(a|b)$";
            Console.WriteLine(Regex.IsMatch("a", reg)); // True
            Console.WriteLine(Regex.IsMatch("b", reg)); // True
            Console.WriteLine(Regex.IsMatch("aaaa", reg)); // False
            Console.WriteLine(Regex.IsMatch("accb", reg)); // False*/

            //作业1
            /* string str = "hello, I am 刘德华,your name is 黎明,黄陆基，数据库?";
             var res = @"[\u4e00-\u9fa5]{2,}";
             var m1=Regex.Matches(str,res);
             foreach (var item in m1)
                 Console.WriteLine(item);*/


            //作业2
            /*string str = "abc  dd  ee  ff  gg  HH  h j k";
            var res1 = @"[ ]";
            var n1 = Regex.Replace(str,res1,"*");
            foreach(var x in n1) Console.Write(x);*/

            //作业3
            /*string str = "我的身份证号是: 360731200111052112,你的身份证是: 42108320041119211X";
            var res2 = @"[1-9]\d{1,18}[\dX]";
            var res3 = @"(\d{4})(\d{2})(\d{2})";
            var res4 = Regex.Matches(str, res2);
            foreach (var item in res4)
            {
                Console.WriteLine(item);
                var n1= item.ToString().Substring(6,8);
                Match res = Regex.Match(n1, res3);
                Console.WriteLine($"{res.Groups[1]}年{res.Groups[2]}月{res.Groups[3]}日");

            }*/



            Console.WriteLine("请输入密码：");
            string res = Console.ReadLine();

            if (!Regex.IsMatch(res, @"^.{8,15}$"))
            {
                Console.WriteLine("密码长度不符合要求（需为8~15位）！");
                return;
            }


            bool hasDigit = Regex.IsMatch(res, @"\d");           // 包含数字
            bool hasLetter = Regex.IsMatch(res, @"[a-zA-Z]");    // 包含字母（大小写）                                                   
            bool hasSpecial = Regex.IsMatch(res, @"\W");         // \W 表示 非(字母、数字、下划线)

            int typeCount = 0;
            if (hasDigit) typeCount++;
            if (hasLetter) typeCount++;
            if (hasSpecial) typeCount++;

            Console.WriteLine("密码长度符合要求。");
            if (typeCount == 1)
            {
                Console.WriteLine("密码强度：弱 (仅包含一种字符)");
            }
            else if (typeCount == 2)
            {
                Console.WriteLine("密码强度：中 (包含两种字符)");
            }
            else if (typeCount == 3)
            {
                Console.WriteLine("密码强度：强 (包含数字、字母和特殊符号)");
            }
            else
            {
                // 理论上 typeCount 不会为 0（除非是空字符串，但上面已经校验了长度）
                Console.WriteLine("密码强度：极弱 (请重新输入)");
            }









        }
    }
}
