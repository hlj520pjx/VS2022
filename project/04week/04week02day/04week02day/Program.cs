using System.Text.RegularExpressions;

namespace _04week02day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //通过下标获取到情报内容：
            /*string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            string salt = "7-16-30-38-49-52-63-70";
            string result = "";

            string[] aa=salt.Split("-");
            for(int i = 0; i < aa.Length; i++)
            {
                int index=int.Parse(aa[i]);
                result += text[index];
            }
            Console.WriteLine(result);*/



            /*//通过情报内容获取到下标：
            string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            string salt = "午夜渡口交换情报";
            List<int> nums = []; // 创建一个list 用于未来的密文索引存储

            for (int i = 0; i < salt.Length; i++)
            {
                int idx = text.IndexOf(salt[i]);
                nums.Add(idx);
            }
            string res=string.Join("-", nums);
            Console.WriteLine(res);*/


            //通过情报内容获取到下标(上一个字符)：
            /*string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            string salt = "午夜渡口交换情报";
            List<int> nums = []; // 创建一个list 用于未来的密文索引存储

            for (int i = 0; i < salt.Length; i++)
            {
                int idx = text.IndexOf(salt[i])-1;
                nums.Add(idx);
            }
            string res = string.Join("-", nums);
            Console.WriteLine(res);*/



//******************************************************************************************************
            /*int money = 123456;
            string str = money.ToString();

            // 创建汉字数组
            string[] arr = ["零", "壹", "贰", "叁", "肆", "伍", "陆", "柒", "捌", "玖"];
            // 创建单位数组
            string[] units = ["", "拾", "佰", "仟", "萬", "拾", "佰", "仟", "亿"];
            string result = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                int idx = int.Parse(str[i].ToString());
                int index = str.Length - 1 - i;// 找单位的下标
                string unit = units[index];// 获取单位

                if (idx != 0)
                {
                    result = arr[idx] + unit + result;
                }
                else
                {
                    if (str.Length - 5 == i)
                    {
                        result = arr[idx] + units[4] + result;
                    }
                    else
                    {
                        result = arr[idx] + result;
                    }
                }
            }
            // 零万 => 万   零零万=>万 零零零万=>万
            result = Regex.Replace(result, @"零+萬", "萬");
            // 多个零都换成一个零
            result = Regex.Replace(result, @"零+", "零");
            // 结尾是零的判断
            if (result.EndsWith("零"))
            {
                // 将零截取掉
                result = result.Substring(0, result.Length - 1);
            }

            Console.WriteLine(result);*/
           // *********************************************************************

            //// 数字转汉字

            ////int money = 555666;
            ////int money = 56;
            int money = 1000086;
            //int money = 1086000;
            ////int money = 123456;
            //// 壹拾贰萬叁仟肆佰伍拾陆
            ///


            // 将money转为字符串,方便后续获取单个数字
            string str = money.ToString();
            string result = "";// 最终数字 转汉字的结果             
            string[] arr = ["零", "壹", "贰", "叁", "肆", "伍", "陆", "柒", "捌", "玖"];// 创建汉字数组// 数字中的单个数字就是 arr中的下标
            string[] units = ["", "拾", "佰", "仟", "萬", "拾", "佰", "仟", "亿"];// 创建单位数组
            // 为了获取数字对应的单位,最好从后往前拿数字 和单位进行匹配
            // 567   /  100086     /  111000086
            // 遍历数字字符串,拿到每一个数字, 拼接汉字

            for (int i = str.Length - 1; i >= 0; i--) // 为了更好的获取到单位 倒序遍历
            {
                int idx = int.Parse(str[i].ToString());//str[i] // 作为arr的下标使用就必须是整数

                /*
                   举例说明: 567  长度是3
                   i       index       ===> i + index = 长度-1
                   2         0    
                   1         1
                   0         2
                 */


                // 第一种方法  数字对应单位的索引下标
                //int index = str.Length - 1 - i;
                //if (idx != 0)
                //{
                //    result = arr[idx] + units[index] + result;
                //}
                //else
                //{
                //    //// 数字是0 但是卡在萬单位上的时候,则不能省略萬单位
                //    //// str长度 减去 萬位置0的下标  一定是 5
                //    //if (str.Length - 5 == i)
                //    //{
                //    //    result = arr[idx] + units[4] + result;
                //    //}
                //    //else
                //    //{
                //    //    result = arr[idx] + result;
                //    //}
                //    // 判断单位是萬则单位保留
                //    if (units[index] == "萬")
                //    {
                //        result = arr[idx] + units[4] + result;
                //    }
                //    else
                //    {
                //        result = arr[idx] + result;
                //    }
                //}


                //第二种方法 如果数字不是0 或则单位是萬  则单位都保留
                int index = str.Length - 1 - i;
                if (idx != 0 || units[index] == "萬")
                {
                    result = arr[idx] + units[index] + result;
                }
                else
                { // 数字是0且单位不是萬则 不保留单位
                    result = arr[idx] + result;
                }

            }

            result = Regex.Replace(result, @"零+萬", "萬");// 正则处理 零+萬问题
            result = Regex.Replace(result, @"零+", "零");// 正则处理 多个连续零问题

            if (result.EndsWith("零"))// 处理结尾是0 的问题 
            {
                result = result.Substring(0, result.Length - 1);
            }
            Console.WriteLine(result);
















        }
    }
}
