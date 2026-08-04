using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("请输入第一个数");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个数");
            double b = double.Parse(Console.ReadLine());
            double sum = a + b;
            Console.WriteLine($"两数之和为{sum}");*/


            /* Console.WriteLine("本地华氏度为:");
             double c = double.Parse(Console.ReadLine());
             double she = 5/9.0 * (c - 32);
             Console.WriteLine($"摄氏度为{she:F3}"); */


            /*Console.WriteLine("sum1的值为:");
            double s1 = double.Parse(Console.ReadLine());
            Console.WriteLine("sum2的值为:");
            double s2 = double.Parse(Console.ReadLine());
            { s1 = s1 + s2; s2 = s1 - s2; s1 = s1 - s2; }
            Console.WriteLine($"sum1={s1} sum2={s2}");*/


            /* Console.WriteLine("连续作战多少小时:");
             int m = int.Parse(Console.ReadLine());
             int day = m / 24;
             int hour = m % 24;
             Console.WriteLine($"连续作战{day}天 {hour}小时");*/

         List<string> name = new List<string>()
         {
             "黄陆基",
             "海少",
             "京爷",
             "沪爷",
             "烧杯",
             "肘击龙",
             "咕咕嘎嘎"
         };
        Random r = new Random();
         Console.WriteLine(name[r.Next(name.Count)]);
           












        }
    }
}
